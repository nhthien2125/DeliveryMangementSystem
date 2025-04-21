using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DeliveryMangementSystem.Models;

namespace DeliveryMangementSystem.GUI
{
    public partial class frmAddBranches: Form
    {
        public frmAddBranches()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chi nhánh!");
                return;
            }
            else
            {
                using (var db = new myDbContext())
                {
                    var branch = new BRANCH
                    {
                        Branch_ID = db.GenerateNewId(db.Branches, b => b.Branch_ID, "BR"),
                        Name = txtName.Text,
                        Address = txtAddress.Text,
                    };

                    db.Branches.Add(branch);
                    db.SaveChanges();
                    MessageBox.Show("Thêm chi nhánh thành công!");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
