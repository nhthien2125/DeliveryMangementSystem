using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DeliveryMangementSystem.Forms;
using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryMangementSystem
{
    public partial class frmLogin : Form
    {
        //Variables
        private const string placeholderText = "Nhập tài khoản của bạn...";
        private readonly myDbContext context;

        //Methods
        public frmLogin()
        {
            InitializeComponent();
            context = new myDbContext();
        }


        //Checkers
        private void CheckLoginButton()
        {
            btnLogin.Enabled = !txtUsername.Text.Equals(placeholderText) 
                            && !string.IsNullOrWhiteSpace(txtUsername.Text) 
                            && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }
        private (bool success, UserRole role) CheckLogin()
        {
            var user = context.Accounts.FirstOrDefault(u => u.Username == txtUsername.Text.Trim() && u.Password == txtPassword.Text.Trim());
            if (user != null) return (true, user.Role);
            else return (false, 0);
        }


        //Events
        private void btnExit_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin().success)
            {
                Hide();
                switch (CheckLogin().role)
                {
                    case UserRole.Admin:
                        new frmAdmin().ShowDialog();
                        break;
                    case UserRole.Shipper:
                        new frmShipper().ShowDialog();
                        break;
                }
                Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            epUsername.SetError(txtUsername, "Nhập tài khoản để tiếp tục");
            epUsername.SetError(txtPassword, "Nhập mật khẩu để tiếp tục");
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == placeholderText)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = placeholderText;
                txtUsername.ForeColor = Color.Gray;
            }
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButton();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckLoginButton();
        }
    }
}
