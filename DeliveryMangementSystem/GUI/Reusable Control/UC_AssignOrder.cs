using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DeliveryMangementSystem.Models;

namespace DeliveryMangementSystem.GUI.Reusable_Control
{
    public partial class UC_AssignOrder: UserControl
    {
        private string shipperId;   
        private void LoadDgvPendingOrders()
        {
            using (var db = new myDbContext())
            {
                var pendingOrders = db.Orders
                    .Where(o => o.Status == Models.OrderStatus.Pending)
                    .Include(o => o.Customer)
                    .Include(o => o.Branch)
                    .Select(o => new
                    {
                        o.Order_ID,
                        Customer_Name = o.Customer.Name,
                        Branch_Name = o.Branch.Name,
                        o.OrderDate,
                        Branch_Address = o.Branch.Address,
                        Customer_Address = o.Customer.Address,
                        o.Total_Amount,
                        o.Payment_Method,
                    })
                    .ToList();
                dgvPendingOrders.DataSource = pendingOrders;
            }
            FormatDgv();
        }
        private void FormatDgv()
        {
            dgvPendingOrders.AutoGenerateColumns = false;
            dgvPendingOrders.Columns.Clear();
            dgvPendingOrders.ReadOnly = true;

            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Order_ID",
                DataPropertyName = "Order_ID",
                HeaderText = "Mã vận đơn",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Customer_Name",
                DataPropertyName = "Customer_Name",
                HeaderText = "Tên khách hàng",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Branch_Name",
                DataPropertyName = "Branch_Name",
                HeaderText = "Tên chi nhánh",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderDate",
                DataPropertyName = "OrderDate",
                HeaderText = "Ngày đặt hàng",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Branch_Address",
                DataPropertyName = "Branch_Address",
                HeaderText = "Địa chỉ nhận đơn",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Customer_Address",
                DataPropertyName = "Customer_Address",
                HeaderText = "Địa chỉ giao hàng",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total_Amount",
                DataPropertyName = "Total_Amount",
                HeaderText = "Tổng giá trị đơn",
                Width = 100,
                ReadOnly = true
            });
            dgvPendingOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Payment_Method",
                DataPropertyName = "Payment_Method",
                HeaderText = "Hình thức thanh toán",
                Width = 100,
                ReadOnly = true
            });

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Action";
            btnColumn.HeaderText = "";
            btnColumn.Text = "Nhận đơn";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPendingOrders.Columns.Add(btnColumn);

        }
        public UC_AssignOrder(string S_Id)
        {
            InitializeComponent();
            LoadDgvPendingOrders();
            this.shipperId = S_Id;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvPendingOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPendingOrders.Columns[e.ColumnIndex].Name == "Action" && e.RowIndex >= 0)
            {
                string orderId = dgvPendingOrders.Rows[e.RowIndex].Cells["Order_ID"].Value.ToString();

                using (var db = new myDbContext())
                {
                    var order = db.Orders.Find(orderId);
                    if (order != null && order.Status == OrderStatus.Pending)
                    {
                        order.Shipper_ID = shipperId;
                        order.Status = OrderStatus.Shipping;

                        db.SaveChanges();
                        MessageBox.Show("Bạn đã nhận đơn thành công!");
                        LoadDgvPendingOrders(); // refresh lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Đơn hàng không còn khả dụng.");
                    }
                }
            }
        }
    }
}
