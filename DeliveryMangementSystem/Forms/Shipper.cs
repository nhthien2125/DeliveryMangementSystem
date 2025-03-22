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
        private void FormatDataGridView()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            dgvOrders.ReadOnly = true;


        }


        //constructor
        public frmShipper(string A_id, string S_id)
        {
            InitializeComponent();
            Account_Id = A_id;
            Shipper_Id = S_id;
            LoadOrdersByShipperID();
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

        }



        //Tabpage Switching by clicking buttons
        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            tctrlShipper.SelectedTab = tpOrderManagement;
        }


        //Events
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new myDbContext())
            {
                dgvOrders.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
