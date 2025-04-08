using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DeliveryMangementSystem.Forms;
using DeliveryMangementSystem.GUI;
using DeliveryMangementSystem.Models;

namespace DeliveryMangementSystem
{
    public partial class frmLogin : Form
    {
        //Attributes
        private const string placeholderText = "Nhập tài khoản của bạn...";
        private readonly myDbContext context;
        bool flagPass = false;


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
        private (bool success, UserRole role, UserStatus status,string Account_id, string Shipper_id) CheckLogin()
        {
            var user = context.Accounts.FirstOrDefault(u => u.Username == txtUsername.Text.Trim() && u.Password == txtPassword.Text.Trim());
            if (user != null) return (true, user.Role, user.Status, user.Account_ID, user.S_ID);
            else return (false, 0, 0, 0.ToString(), 0.ToString());
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
                if (CheckLogin().status == UserStatus.Inactive)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa hoặc chưa được kích hoạt", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Hide();
                    switch (CheckLogin().role)
                    {
                        case UserRole.Admin:
                            DialogResult result = MessageBox.Show("You are signing as admin! \nYour account id is: " + CheckLogin().Account_id, "Admin", MessageBoxButtons.OK);
                            new frmAdmin(CheckLogin().Account_id).ShowDialog();
                            break;
                        case UserRole.Shipper:
                            DialogResult result1 = MessageBox.Show("You are signing as shipper! \nYour account id is: " + CheckLogin().Account_id, "Shipper", MessageBoxButtons.OK);
                            new frmShipper(CheckLogin().Account_id, CheckLogin().Shipper_id).ShowDialog();
                            break;
                    }
                    txtPassword.Clear();
                    Show();
                }
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
        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!flagPass)
            {
                txtPassword.PasswordChar = '\0';
                flagPass = true;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                flagPass = false;
            }
        }

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmSignUp().ShowDialog();
            this.Show();

            txtPassword.Clear();
        }
    }
}
