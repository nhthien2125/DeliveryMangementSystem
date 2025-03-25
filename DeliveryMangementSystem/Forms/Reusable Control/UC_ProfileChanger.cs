using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DeliveryMangementSystem.Forms.Reusable_Control
{
    public partial class UC_ProfileChanger : UserControl
    {
        //Attributes
        private string userID;
        private string role;

        //Constructor
        public UC_ProfileChanger(string userID, string role)
        {
            InitializeComponent();
            this.userID = userID;
            this.role = role;
            LoadUserData();
        }
        private void LoadUserData()
        {
            //load user data from database
            using (var db = new myDbContext())
            {
                if (role == "Admin")
                {
                    var admin = db.Accounts.Find(userID);
                    txtAccountId.Text = admin.Id;
                }
                else if (role == "Shipper")
                {
                    var shipper = db.Accounts.Find(userID);
                    txtAccountId.Text = shipper.Id;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new myDbContext())
            {
                if (role == "Admin")
                {
                    if (txtPassword.Text == db.Accounts.Find(userID).Password)
                    {
                        var admin = db.Accounts.Find(userID);
                        admin.Password = txtNewPassword.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Parent.Controls.Remove(this);
                    }
                    else
                    {
                        MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (role == "Shipper")
                {
                    if (txtPassword.Text != db.Accounts.Find(userID).Password)
                    {
                        MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else 
                    { 
                        var shipper = db.Accounts.Find(userID);
                        shipper.Password = txtNewPassword.Text;
                        db.SaveChanges();
                        MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Parent.Controls.Remove(this);
                    }  
                }
            }
        }

        private void UC_ProfileChanger_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
        }
    }
}
