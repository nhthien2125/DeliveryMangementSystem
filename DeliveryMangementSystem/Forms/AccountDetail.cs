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

namespace DeliveryMangementSystem.Forms
{
    public partial class frmAccountDetail : Form
    {
        public frmAccountDetail(string id, string name, string phone, string email, string role)
        {
            InitializeComponent();

            // Hiển thị dữ liệu lên Label
            lblAccountID.Text = id;
            lblAccountName.Text = name;
            lblPhone.Text = phone;
            lblEmail.Text = email;
            lblRole.Text = role;
        }
    }
}
