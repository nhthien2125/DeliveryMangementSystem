using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMangementSystem.Forms.Reusable_Control
{
    public partial class ProfileChanger : UserControl
    {
        //Attributes
        private string userID;
        private string role;

        //Constructor
        public ProfileChanger(string userID, string role)
        {
            InitializeComponent();
            this.userID = userID;
            this.role = role;
            //LoadUserData();
        }
        //        private void LoadUserData() {
        //            //load user data from database
        //            using (var db = new myDbContext())
        //            {
        //                if (role == "Admin")
        //                {
        //                    var admin = db.Accounts.Find(userID);
        //                    txtAdminId.text = admin.Id;
        //                    txtUsername.Text = admin.Username;
        //                }
        //                else if (role == "Shipper")
        //                {
        //                    var shipper = db.Shippers.Find(userID);
        //                    txtId.Text = shipper.Id;
        //                    txtName.Text = shipper.Name;
        //                    txtPhone.Text = shipper.Phone;
        //                }
        //            }
        //        }
    }    
}
