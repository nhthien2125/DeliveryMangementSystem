using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using DeliveryMangementSystem.Forms.Reusable_Control;
namespace DeliveryMangementSystem.Forms
{
    public partial class frmAdmin : Form
    {
        //Attributes
        private readonly string Id;

        //Methods
        private void LoadDataGridViewAccounts()
        {
            //Load ds tài khoản (trừ admin) vào datagridview
            using (var db = new myDbContext())
            {
                var accounts = db.Accounts.Where(o => o.Role != Models.UserRole.Admin).ToList();
                dgvAccounts.DataSource = accounts;
                
            }
            FormatDataGridView();
        }
        private void FormatDataGridView()
        {
            dgvAccounts.AutoGenerateColumns = false;
            dgvAccounts.Columns.Clear();
            dgvAccounts.ReadOnly = true;

            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "Id",
                HeaderText = "Mã tài khoản",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Username",
                DataPropertyName = "Username",
                HeaderText = "Tên đăng nhập",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                DataPropertyName = "Role",
                HeaderText = "Vai trò",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }


        //Constructor
        public frmAdmin(string id)
        {
            InitializeComponent();
            this.Id = id;
            LoadDataGridViewAccounts();
        }
        private void frmAdmin_Load_1(object sender, EventArgs e)
        {
            tabControlAdmin.Appearance = TabAppearance.FlatButtons;
            tabControlAdmin.SizeMode = TabSizeMode.Fixed;
            tabControlAdmin.ItemSize = new Size(0, 1); // Thu nhỏ tab để ẩn tiêu đề
            tabControlAdmin.Multiline = true;
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
            UC_ProfileChanger uC_ProfileChanger = new UC_ProfileChanger(Id, "Admin")
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(uC_ProfileChanger);
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
                    var account = db.Accounts.FirstOrDefault(a => a.Id == accountId);
                    if (account != null && account.ShipperId != null)
                    {
                        var shipper = db.Shippers.Find(account.ShipperId);
                        if (shipper != null)
                        {
                            var frm = new frmAccountDetail(shipper.Id);
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
                    var account = db.Accounts.Find(accountId);
                    if (account != null)
                    {
                        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {accountId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.Accounts.Remove(account);
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
}
