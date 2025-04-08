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
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DeliveryMangementSystem.GUI
{
    public partial class frmSignUp: Form
    {
        //Atributes
        private readonly myDbContext _context;
        bool flagPass = false;

        //Constructor
        public frmSignUp()
        {
            InitializeComponent();
            _context = new myDbContext();
            txtPassword.PasswordChar = '*';
            txtConfirmPass.PasswordChar = '*';
        }

        //Methods


        //Checkers
        private bool InfoIsFilled()
        {
            return !string.IsNullOrWhiteSpace(txtUsername.Text) &&
        !string.IsNullOrWhiteSpace(txtPassword.Text) &&
        !string.IsNullOrWhiteSpace(txtConfirmPass.Text) &&
        !string.IsNullOrWhiteSpace(txtName.Text) &&
        !string.IsNullOrWhiteSpace(txtPhone.Text) &&
        !string.IsNullOrWhiteSpace(txtMail.Text);
        }
        private bool IsUsernameExist(string username)
        {
            return _context.Accounts.Any(a => a.Username.Equals(username));
        }

        //Events
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfoIsFilled())
                {
                    if (txtPassword.Text.Trim().Equals(txtConfirmPass.Text.Trim()))
                    {
                        if (IsUsernameExist(txtUsername.Text.Trim()))
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại!");
                            this.DialogResult = DialogResult.None;
                            return;
                        }
                        else
                        {
                            var newAccount = new ACCOUNT
                            {
                                Account_ID = _context.GenerateNewId(_context.Accounts, a => a.Account_ID, "ACC"),
                                Username = txtUsername.Text.Trim(),
                                Password = txtPassword.Text.Trim(),
                                Role = UserRole.Shipper
                            };
                            var newShipper = new SHIPPER
                            {
                                Shipper_ID = _context.GenerateNewId(_context.Shippers, s => s.Shipper_ID, "SHIPPER"),
                                Name = txtName.Text.Trim(),
                                Phone = txtPhone.Text.Trim(),
                                Email = txtMail.Text.Trim()
                            };
                            _context.Accounts.Add(newAccount);
                            _context.Shippers.Add(newShipper);

                            _context.SaveChanges();
                            MessageBox.Show("Đăng ký thành công!");
                            this.DialogResult = DialogResult.OK;
                            var newFID = _context.GenerateNewId(_context.Accounts, a => a.S_ID, "SHIPPER");
                            newAccount.S_ID = newFID;
                            _context.SaveChanges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp!");
                        this.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin! \n");
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!flagPass)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                flagPass = true;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
                flagPass = false;
            }
        }
    }
}
