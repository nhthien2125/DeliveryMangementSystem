using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace DeliveryMangementSystem.Forms
{
    public partial class frmAdmin: Form
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
                HeaderText = "ID",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Username",
                DataPropertyName = "Username",
                HeaderText = "Username",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Password",
                DataPropertyName = "Password",
                HeaderText = "Password",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                DataPropertyName = "FullName",
                HeaderText = "FullName",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                DataPropertyName = "Phone",
                HeaderText = "Phone",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BranchId",
                DataPropertyName = "BranchId",
                HeaderText = "BranchId",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                DataPropertyName = "Role",
                HeaderText = "Role",
                Width = 100
            });
            dgvAccounts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreatedDate",
                DataPropertyName = "CreatedDate",
                HeaderText = "CreatedDate",
                Width = 100
            });
        }


        //Constructor
        public frmAdmin(string id = "DefaultID")
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
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                using (var db = new myDbContext())
                {
                    string accountId = dgvAccounts.SelectedRows[0].Cells["ID"].Value.ToString();
                    var account = db.Accounts.Find(accountId);

                    if (account != null)
                    {
                        
                    }
                }
            }
        }
    }
}
