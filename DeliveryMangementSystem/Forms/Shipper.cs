using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryMangementSystem.Models;

namespace DeliveryMangementSystem.Forms
{
    public partial class frmShipper: Form
    {
        //Attributes
        private readonly string Account_Id;
        private readonly string Shipper_Id;

        //Methods
        private void LoadOrdersByShipperID()
        {
            //load orders from database to datagridview
            using (var db = new myDbContext())
            {
                var orders = db.Orders.Where(o => o.ShipperId == Shipper_Id).ToList();
                dgvOrders.DataSource = orders;
            }
            FormatDataGridView();
        }
        private void LoadProfileByShipperID()
        {
            //load profile from database to textboxes
            using (var db = new myDbContext())
            {
                var shipper = db.Shippers.Find(Shipper_Id);
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


        //constructor
        public frmShipper(string A_id, string S_id)
        {
            InitializeComponent();
            Account_Id = A_id;
            Shipper_Id = S_id;
            LoadOrdersByShipperID();
            LoadProfileByShipperID();
        }
        private void frmShipper_Load(object sender, EventArgs e)
        {
            // Lấy danh sách giá trị từ enum OrderStatus
            var statusList = Enum.GetValues(typeof(OrderStatus))
                                 .Cast<OrderStatus>()
                                 .Select(s => new { Value = s, Text = s.ToString() })
                                 .ToList();

            cbbStatus.DataSource = statusList;
            cbbStatus.ValueMember = "Value";  // Lưu Enum vào ValueMember
            cbbStatus.DisplayMember = "Text"; // Hiển thị tên Enum
            cbbStatus.SelectedIndex = 0;

            tctrlShipper.Appearance = TabAppearance.FlatButtons;
            tctrlShipper.SizeMode = TabSizeMode.Fixed;
            tctrlShipper.ItemSize = new Size(0, 1); // Ẩn tab
            tctrlShipper.Multiline = true;
        }



        //Tabpage Switching by clicking buttons
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            tctrlShipper.SelectedTab = tpOrderManagement;
        }
        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            tctrlShipper.SelectedTab = tpProfile;
        }


        //Events
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
                    db.SaveChanges();
                    LoadOrdersByShipperID();
                }
            }
            else MessageBox.Show("Vui lòng chọn một đơn hàng để cập nhật trạng thái giao hàng!");
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
