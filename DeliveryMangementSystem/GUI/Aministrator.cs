using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using DeliveryMangementSystem.Forms.Reusable_Control;
using Microsoft.EntityFrameworkCore;
using DeliveryMangementSystem.Models;
using DeliveryMangementSystem.GUI;
using DeliveryMangementSystem.GUI.Reusable_Control;
using System.IdentityModel.Protocols.WSTrust;
namespace DeliveryMangementSystem.Forms
{
    public partial class frmAdmin : Form
    {
        //Varriables
        private readonly string Id;
        private ToolStripDropDown managementDropDown;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDeleteBranch;


        //Methods
        private void LoadDataGridViewBranches()
        {
            //Load ds chi nhánh vào datagridview
            using (var db = new myDbContext())
            {
                var branches = db.Branches.Include(o => o.Orders).Select(b => new
                {
                    b.Branch_ID,
                    b.Name,
                    b.Address,
                    NumberOfOrders = b.Orders.Count(),
                    PendingOrders = b.Orders.Where(o => o.Status == OrderStatus.Pending).Count(),
                    TotalAmount = b.Orders.Where(o => o.Status  == OrderStatus.Delivered).Sum(o => o.Total_Amount),
                    Status = b.Orders.Count() > 0 ? "Đang hoạt động" : "Ngừng hoạt động"
                }).ToList();
                dgvBranches.DataSource = branches;
            }
            FormatDataGridViewB();
        }
        private void LoadDataGridViewAccounts()
        {
            //Load ds tài khoản vào datagridview
            using (var db = new myDbContext())
            {
                var accounts = db.Accounts.Include(a => a.Shipper).Where(s => s.Role != UserRole.Admin).Select(a => new
                {
                    a.Account_ID,
                    Username = a.Username,
                    Name = a.Shipper != null ? a.Shipper.Name : "",
                    a.Role,
                    a.Status
                }).ToList();
                dgvAccounts.DataSource = accounts;
         
            }
            FormatDataGridViewA();
        }
        private void FormatDataGridViewA()
        {
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.Columns.Clear();
            dgvAccounts.ReadOnly = true;

            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "Account_ID",
                HeaderText = "Mã tài khoản",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Chủ tài khoản",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                DataPropertyName = "Role",
                HeaderText = "Vai trò",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Trạng thái tài khoản",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Font = new Font("Arial", 8);
        } //for dgvAccounts
        private void FormatDataGridViewB()
        {
            dgvBranches.AutoGenerateColumns = false;
            dgvBranches.Columns.Clear();
            dgvBranches.ReadOnly = true;
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Branch_ID",
                DataPropertyName = "Branch_ID",
                HeaderText = "Mã chi nhánh",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Tên chi nhánh",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                DataPropertyName = "Address",
                HeaderText = "Địa chỉ",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumberOfOrders",
                DataPropertyName = "NumberOfOrders",
                HeaderText = "Tổng số đơn hàng",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PendingOrders",
                DataPropertyName = "PendingOrders",
                HeaderText = "Số đơn hàng đang chờ xử lý",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                DataPropertyName = "TotalAmount",
                HeaderText = "Tổng doanh thu",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvBranches.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Tình trạng hoạt động",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBranches.Font = new Font("Arial", 8);
        } //for dgvBranches

        private void CustomizedMenuManager()
        {
            //Dropdown 
            managementDropDown = new ToolStripDropDown();

            btnAdd = new Button
            {
                Text = "Thêm",
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black
            };
            btnAdd.Click += (s, e) =>
            {
                var frm = new frmAddBranches();
                frm.ShowDialog();
                LoadDataGridViewBranches();
            };

            btnEdit = new Button
            {
                Text = "Sửa",
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black
            };
            btnEdit.Click += (s, e) =>
            {
                if (dgvBranches.SelectedRows.Count == 1)
                {
                    string branchId = dgvBranches.SelectedRows[0].Cells["Branch_ID"].Value.ToString();
                    UC_BranchChanger uC_BranchChanger = new UC_BranchChanger(branchId)
                    {
                        Dock = DockStyle.Fill
                    };
                    pnlBranch.Controls.Add(uC_BranchChanger);
                    uC_BranchChanger.BringToFront();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một chi nhánh!");
                }
            };

            btnDeleteBranch = new Button
            {
                Text = "Xóa",
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Black
            };
            btnDeleteBranch.Click += (s, e) =>
            {
                if (dgvBranches.SelectedRows.Count == 1)
                {
                    string branchId = dgvBranches.SelectedRows[0].Cells["Branch_ID"].Value.ToString();
                    using (var db = new myDbContext())
                    {
                        var branch = db.Branches.Include(o => o.Orders).FirstOrDefault(o => o.Branch_ID == branchId);
                        if (branch != null)
                        {
                            if (branch.Orders.Count() > 0)
                            {
                                MessageBox.Show("Chi nhánh này đang hoạt động, không thể xóa!");
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa chi nhánh {branchId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    db.Branches.Remove(branch);
                                    db.SaveChanges();
                                    LoadDataGridViewBranches();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một chi nhánh!");
                }
            };
            managementDropDown.Items.Add(new ToolStripControlHost(btnAdd));
            managementDropDown.Items.Add(new ToolStripControlHost(btnEdit));
            managementDropDown.Items.Add(new ToolStripControlHost(btnDeleteBranch));

            tsmMenuManagement.DropDown = managementDropDown;
        }


        //Constructor
        public frmAdmin(string id)
        {
            InitializeComponent();
            this.Id = id;
            LoadDataGridViewAccounts();
            LoadDataGridViewBranches();
        }
        private void frmAdmin_Load_1(object sender, EventArgs e)
        {
            tabControlAdmin.Appearance = TabAppearance.FlatButtons;
            tabControlAdmin.SizeMode = TabSizeMode.Fixed;
            tabControlAdmin.ItemSize = new Size(0, 1); // Thu nhỏ tab để ẩn tiêu đề
            tabControlAdmin.Multiline = true;

            CustomizedMenuManager();
        }


        // Tab Switching btns
        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tpAccount;
        }
        private void btnBranchManagement_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tpBranch;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tpChangePassword;
            UC_ProfileChanger uC_ProfileChanger = new UC_ProfileChanger(Id, "Admin")
            {
                Dock = DockStyle.Fill
            };
            tpChangePassword.Controls.Add(uC_ProfileChanger);
            uC_ProfileChanger.BringToFront();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) this.Close();
        }
        

        //event
        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 1)
            {
                string accountId = dgvAccounts.SelectedRows[0].Cells["ID"].Value.ToString();

                using (var db = new myDbContext())
                {
                    var account = db.Accounts.FirstOrDefault(a => a.Account_ID == accountId);
                    if (account != null && account.S_ID != null)
                    {
                        var shipper = db.Shippers.Find(account.S_ID);
                        if (shipper != null)
                        {
                            var frm = new frmAccountDetail(shipper.Shipper_ID, null);
                            frm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 1)
            {
                string accountId = dgvAccounts.SelectedRows[0].Cells["ID"].Value.ToString();
                using (var db = new myDbContext())
                {
                    var account = db.Accounts
                        .Include(a => a.Shipper)
                        .FirstOrDefault(a => a.Account_ID == accountId);
                    if (account != null)
                    {
                        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {accountId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (account.Status == UserStatus.Active)
                            {
                                MessageBox.Show("Tài khoản đang hoạt động, không thể xóa!");
                            }
                            else
                            {
                                var orders = db.Orders.Where(o => o.Shipper_ID == account.S_ID).ToList();
                                foreach (var order in orders)
                                {
                                    order.Status = OrderStatus.Pending;
                                    order.Shipper_ID = null;
                                }

                                db.Shippers.Remove(account.Shipper);
                                db.Accounts.Remove(account);
                                db.SaveChanges();
                                LoadDataGridViewAccounts();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản!");
            }
        }
        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            using (var db = new myDbContext())
            {
                if (dgvAccounts.SelectedRows.Count == 1)
                {
                    string accountId = dgvAccounts.SelectedRows[0].Cells["ID"].Value.ToString();
                    var account = db.Accounts.Find(accountId);
                    if (account != null)
                    {
                        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn vô hiệu hóa tài khoản {accountId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (account.Status == UserStatus.Inactive)
                            {
                                MessageBox.Show("Tài khoản đã bị vô hiệu hóa!");
                            }
                            else
                            {
                                account.Status = UserStatus.Inactive;
                                db.SaveChanges();
                                LoadDataGridViewAccounts();
                            }
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản!");
                }
            }
        }
        private void btnActive_Click(object sender, EventArgs e)
        {
            using (var db = new myDbContext())
            {
                if (dgvAccounts.SelectedRows.Count == 1)
                {
                    string accountId = dgvAccounts.SelectedRows[0].Cells["ID"].Value.ToString();
                    var account = db.Accounts.Find(accountId);
                    if (account != null)
                    {
                        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn kích hoạt tài khoản {accountId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (account.Status == UserStatus.Active)
                            {
                                MessageBox.Show("Tài khoản đã được kích hoạt!");
                            }
                            else
                            {
                                account.Status = UserStatus.Active;
                                db.SaveChanges();
                                LoadDataGridViewAccounts();
                            }
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản!");
                }
            }
        }
        private void dgvBranches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new myDbContext())
            {
                if (e.RowIndex >= 0 && e.ColumnIndex <= 1)
                {
                    var detailsOrder = db.Orders
                        .Include(o => o.Shipper)
                        .Include(o => o.Customer)
                        .Where(o => o.Branch_ID == dgvBranches.Rows[e.RowIndex].Cells["Branch_ID"].Value.ToString())
                        .OrderByDescending(o => o.Status)
                        .Select(o => new
                        {
                            o.Order_ID,
                            o.Customer.Name,
                            Shipper = o.Shipper_ID != null ? o.Shipper.Name : "Chưa phân công",
                            o.OrderDate,
                            o.Delivery_Date,
                            o.Total_Amount,
                            o.Status
                        }).ToList();


                    dgvDetails.DataSource = detailsOrder;
                    lblDetails.Text = "Chi tiết đơn hàng của " + dgvBranches.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                }

                //Format 
                dgvDetails.AutoGenerateColumns = false;
                dgvDetails.Columns.Clear();
                dgvDetails.ReadOnly = true;
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Order_ID",
                    DataPropertyName = "Order_ID",
                    HeaderText = "Mã đơn hàng",
                    Width = 80
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Name",
                    DataPropertyName = "Name",
                    HeaderText = "Tên khách hàng",
                    Width = 80

                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Shipper",
                    DataPropertyName = "Shipper",
                    HeaderText = "Shipper",
                    Width = 80
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "OrderDate",
                    DataPropertyName = "OrderDate",
                    HeaderText = "Ngày đặt hàng",
                    Width = 80
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Delivery_Date",
                    DataPropertyName = "Delivery_Date",
                    HeaderText = "Ngày giao hàng",
                    Width = 80
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Total_Amount",
                    DataPropertyName = "Total_Amount",
                    HeaderText = "Tổng tiền",
                    Width = 80
                });
                dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Status",
                    DataPropertyName = "Status",
                    HeaderText = "Trạng thái",
                    Width = 80
                });
                dgvDetails.Font = new Font("Arial", 10);
            }
        }

    }
}
