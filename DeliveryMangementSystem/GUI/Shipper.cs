using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMangementSystem.Forms.Reusable_Control;
using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryMangementSystem.Forms
{
    public partial class frmShipper: Form
    {
        //Attributes
        private readonly string Account_Id;
        private readonly string Shipper_Id;
        private readonly myDbContext db = new myDbContext();
        private ToolStripDropDown dropDown;
        private CheckedListBox clbStatusFilter;
        private CheckedListBox clbPaymentFilter;
        private List<OrderStatus> selectedStatuses = new List<OrderStatus>();
        private List<PaymentMethod> selectedPaymentMethods = new List<PaymentMethod>();


        //Methods
        private void LoadOrdersByShipperID()
        {
            //load orders from database to datagridview
            var orders = db.Orders.Where(o => o.ShipperId == Shipper_Id).AsNoTracking().ToList();
            dgvOrders.DataSource = orders;

            FormatDataGridView();
        }
        private void LoadCompletedOrders()
        {
            //load completed orders from database to datagridview
            var orders = db.Orders.Where(o => o.ShipperId == Shipper_Id && o.Status == OrderStatus.Delivered).AsNoTracking().ToList();
            dgvCompletedOrders.DataSource = orders;

            FormatDataGridView();
        }
        private void LoadProfileByShipperID()
        {
            //load profile from database to labels
            var shipper = db.Shippers.Find(Shipper_Id);
            if (shipper != null)
            {
                lblID.Text = shipper.Id;
                lblName.Text = shipper.Name;
                lblPhone.Text = shipper.Phone;
            }
        }
        private void FormatDataGridView()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            dgvOrders.ReadOnly = true;

            dgvCompletedOrders.AutoGenerateColumns = false;
            dgvCompletedOrders.Columns.Clear();
            dgvCompletedOrders.ReadOnly = true;

            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "Mã vận đơn",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BranchId",
                HeaderText = "Chi nhánh nhận đơn",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Khách hàng",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                HeaderText = "Ngày đặt",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeliveryDate",
                DataPropertyName = "DeliveryDate",
                HeaderText = "Ngày giao",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Trạng thái giao hàng",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "Phương thức thanh toán",
                Width = 100
            });
            dgvCompletedOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Tổng tiền",
                Width = 100
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "Mã vận đơn",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BranchId",
                HeaderText = "Chi nhánh nhận đơn",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Khách hàng",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                HeaderText = "Ngày đặt",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeliveryDate",
                HeaderText = "Ngày giao",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Trạng thái giao hàng",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "Phương thức thanh toán",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Tổng tiền",
                Width = 100
            });
        }
        private void CustomizedMenuStatusFilter()
        {
            // DropDown
            dropDown = new ToolStripDropDown();

            // CheckedListBox
            clbStatusFilter = new CheckedListBox()
            {
                CheckOnClick = true,
            };

            // Get Enum values
            clbStatusFilter.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());

            // Host
            ToolStripControlHost host = new ToolStripControlHost(clbStatusFilter);
            dropDown.Items.Add(host);
            clbStatusFilter.ItemCheck += clbStatusFilter_ItemCheck;

            tsbStatusFilter.DropDown = dropDown;
        }
        private void CustomizrdMenuPaymentFilter()
        {
            // DropDown
            dropDown = new ToolStripDropDown();

            // CheckedListBox
            clbPaymentFilter = new CheckedListBox()
            {
                CheckOnClick = true,
            };

            // Get Enum values
            clbPaymentFilter.Items.AddRange(Enum.GetValues(typeof(PaymentMethod)).Cast<object>().ToArray());

            // Host
            ToolStripControlHost host = new ToolStripControlHost(clbPaymentFilter);
            dropDown.Items.Add(host);
            clbPaymentFilter.ItemCheck += clbPaymentFilter_ItemCheck;

            tsbPaymentFilter.DropDown = dropDown;
            
        }
        //constructor
        public frmShipper(string A_id, string S_id)
        {
            InitializeComponent();
            Account_Id = A_id;
            Shipper_Id = S_id;
            LoadOrdersByShipperID();
            LoadCompletedOrders();
            LoadProfileByShipperID();
        }
        private void frmShipper_Load(object sender, EventArgs e)
        {
            // Get values from enum OrderStatus for cbbStatus
            var statusList = Enum.GetValues(typeof(OrderStatus))
                                 .Cast<OrderStatus>()
                                 .Select(s => new { Value = s, Text = s.ToString() })
                                 .ToList();

            cbbStatus.DataSource = statusList;
            cbbStatus.ValueMember = "Value";  // Set ValueMember with enum value
            cbbStatus.DisplayMember = "Text"; // Show enum name
            cbbStatus.SelectedIndex = -1;      // Set Default to null

            // hiding tab headers
            tctrlShipper.Appearance = TabAppearance.FlatButtons;
            tctrlShipper.SizeMode = TabSizeMode.Fixed;
            tctrlShipper.ItemSize = new Size(0, 1); 
            tctrlShipper.Multiline = true;

            CustomizedMenuStatusFilter();
            CustomizrdMenuPaymentFilter();
        }



        //Tabpage Switching
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            tctrlShipper.SelectedTab = tpOrderManagement;
        }
        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            tctrlShipper.SelectedTab = tpProfile;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            tctrlShipper.SelectedTab = tpChangePass;
            UC_ProfileChanger uc = new UC_ProfileChanger(Account_Id, "Shipper")
            {
                Dock = DockStyle.Fill
            };

            pnlChange.Controls.Add(uc);
            uc.BringToFront();
        }


        //Events
        private void clbPaymentFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checkedItem = (PaymentMethod)clbPaymentFilter.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                selectedPaymentMethods.Add(checkedItem);
            }
            else
            {
                selectedPaymentMethods.Remove(checkedItem);
            }
        }
        private void clbStatusFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checkedItem = (OrderStatus)clbStatusFilter.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                selectedStatuses.Add(checkedItem);
            }
            else
            {
                selectedStatuses.Remove(checkedItem);
            }
        }
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                using (var db = new myDbContext())
                {
                    string orderId = dgvOrders.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    var order = db.Orders.Find(orderId);
                    cbbStatus.SelectedValue = order.Status;
                }
            }
        } 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count ==1 )
            {
                using (var db = new myDbContext())
                {
                    var order = db.Orders.Find(dgvOrders.SelectedRows[0].Cells[0].Value);
                    order.Status = (OrderStatus)cbbStatus.SelectedValue;
                    
                    if (order.Status == OrderStatus.Delivered) order.DeliveryDate = DateTime.Now;
                    else order.DeliveryDate = null;
                    db.SaveChanges();

                    LoadOrdersByShipperID();
                    LoadCompletedOrders();
                    MessageBox.Show("Cập nhật trạng thái đơn hàng thành công!");
                }
            }
            else MessageBox.Show("Vui lòng chọn một đơn hàng để cập nhật trạng thái giao hàng!");
        } // Update order status
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất tài khoản hiện tại?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void btnApply_Click_1(object sender, EventArgs e)
        {
            var orders = db.Orders.Where(o => o.ShipperId == Shipper_Id);

            if (selectedStatuses.Any())
            {
                orders = orders.Where(o => selectedStatuses.Contains(o.Status));
            }
            if (selectedPaymentMethods.Any())
            {
                orders = orders.Where(o => selectedPaymentMethods.Contains(o.PaymentMethod));
            }
            dgvOrders.DataSource = orders.ToList();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            LoadOrdersByShipperID();
        }
    }
}
