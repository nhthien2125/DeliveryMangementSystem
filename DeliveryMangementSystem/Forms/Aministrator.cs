using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //xóa mấy cái màu xám đi (giảm tải khi chạy)

namespace DeliveryMangementSystem.Forms
{
    public partial class frmAdmin: Form
    {
        //Attributes
        private readonly string Id; //thuộc tính lưu trữ tạm id truyền vào constructor phía dưới

        // Khai báo UserControl nhưng chưa khởi tạo ngay (tối ưu hiệu suất)
        private UC_ManageUsers ucManageUsers;
        private UC_Branches ucManageBranches;
        private UC_Orders ucOrders;
        private UC_Customers ucCustomers;
        private UC_Shippers ucShippers;

        //Constructor (truyền tham số id của admin)
        public frmAdmin(string id)
        {
            InitializeComponent();
            this.Id = id; //this.Id là thuộc tính của class, id là tham số truyền vào
        }

        private void grid_Paint(object sender, PaintEventArgs e)
        {

        }

        // Chuyển đổi giữa các tab
        private void titleAccount_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = AccountPage;
        }

        private void titleBranch_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = BranchPage;
        }

        private void titleCustomer_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = CustomerPage;
        }

        private void titleOrder_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = OrderPage;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = ShipperPage;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
        private void nameBrandM_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa UserControl cũ trước khi thêm cái mới (tránh bị đè lên)
            tabControlAdmin.SelectedTab.Controls.Clear();

            // Kiểm tra tab nào đang được chọn và tải UserControl tương ứng
            switch (tabControlAdmin.SelectedIndex)
            {
                case 0: // Quản lý người dùng
                    if (ucManageUsers == null)
                        ucManageUsers = new UC_ManageUsers();
                    tabControlAdmin.SelectedTab.Controls.Add(ucManageUsers);
                    break;

                case 1: // Quản lý chi nhánh
                    if (ucManageBranches == null)
                        ucManageBranches = new UC_Branches();
                    tabControlAdmin.SelectedTab.Controls.Add(ucManageBranches);
                    break;

                case 2: // Quản lý đơn hàng
                    if (ucOrders == null)
                        ucOrders = new UC_Orders();
                    tabControlAdmin.SelectedTab.Controls.Add(ucOrders);
                    break;

                case 3: // Quản lý khách hàng
                    if (ucCustomers == null)
                        ucCustomers = new UC_Customers();
                    tabControlAdmin.SelectedTab.Controls.Add(ucCustomers);
                    break;

                case 4: // Quản lý Shippers
                    if (ucShippers == null)
                        ucShippers = new UC_Shippers();
                    tabControlAdmin.SelectedTab.Controls.Add(ucShippers);
                    break;
            }

            // Đảm bảo UserControl hiển thị đầy đủ trong tab
            if (tabControlAdmin.SelectedTab.Controls.Count > 0)
            {
                tabControlAdmin.SelectedTab.Controls[0].Dock = DockStyle.Fill;
            }
        }
    }
}
