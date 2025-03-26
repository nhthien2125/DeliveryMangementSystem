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
        private readonly string ShipperID;
        public frmAccountDetail(string S_Id)
        {
            InitializeComponent();
            ShipperID = S_Id;
        }
        private void frmAccountDetail_Load_1(object sender, EventArgs e)
        {
            using (var db = new myDbContext())
            {
                var shipper = db.Shippers.Find(ShipperID);
                if (shipper != null)
                {
                    lblUserId.Text = shipper.Id.ToString();
                    lblName.Text = shipper.Name;
                    lblRole.Text = shipper.Phone;
                    
                }
            }
        }
    }
}