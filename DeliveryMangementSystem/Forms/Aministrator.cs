using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace DeliveryMangementSystem.Forms
{
    public partial class frmAdmin : Form
    {
        //Attributes
        private readonly string Id;

        //Methods
        private void LoadDataGridViewAccounts()
        {
            //Load ds tài khoản vào datagridview
            using (var db = new myDbContext())
            {
                var accounts = db.Accounts.ToList();
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
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Username",
                DataPropertyName = "Username",
                HeaderText = "Tên đăng nhập",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                DataPropertyName = "Role",
                HeaderText = "Vai trò",
                Width = 100
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


        // Chuyển đổi giữa các tab
        private void titleAccount_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tpAccount;
        }

        private void titleBranch_Click(object sender, EventArgs e)
        {
            tabControlAdmin.SelectedTab = tpBranch;
        }

        private void titleLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //event
        private void AccountPage_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)  // Kiểm tra nếu có dòng được chọn
            {
                string id = dgvAccounts.SelectedRows[0].Cells["Id"].Value.ToString();
                string name = dgvAccounts.SelectedRows[0].Cells["Name"].Value.ToString();
                string phone = dgvAccounts.SelectedRows[0].Cells["Phone"].Value.ToString();
                string email = dgvAccounts.SelectedRows[0].Cells["Email"].Value.ToString();
                string role = dgvAccounts.SelectedRows[0].Cells["Role"].Value.ToString();

                // Truyền dữ liệu vào constructor
                frmAccountDetail detailForm = new frmAccountDetail(id, name, phone, email, role);
                detailForm.ShowDialog(); // Hiển thị form chi tiết
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
