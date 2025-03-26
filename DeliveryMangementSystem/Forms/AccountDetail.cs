using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using DeliveryMangementSystem.Models;  // Import model


namespace DeliveryMangementSystem.Forms
{
    public partial class frmAccountDetail : Form
    {
        private string AccountID;
        public frmAccountDetail(string id, string name, string phone, string email, string role)
        {
            InitializeComponent();
            AccountID = id;
        }
        private void frmAccountDetail_Load(object sender, EventArgs e)
        {
            using (var db = new myDbContext()) // Kết nối database
            {
                var account = db.Accounts.FirstOrDefault(a => a.Id == AccountID);
                if (account != null)
                {
                    lblAccountID.Text = account.Id;
                    lblAccountName.Text = account.Username;
                    lblRole.Text = account.Role.ToString(); 
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Đóng form nếu không tìm thấy tài khoản
                }
            }
        }
    }
}