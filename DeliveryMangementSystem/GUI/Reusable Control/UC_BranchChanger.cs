using System;
using System.Linq;
using System.Windows.Forms;

namespace DeliveryMangementSystem.GUI.Reusable_Control
{
    public partial class UC_BranchChanger: UserControl
    {
        private string Branch_ID;
        public UC_BranchChanger(string id)
        {
            InitializeComponent();
            Branch_ID = id;
            
        }

        private void UC_BranchChanger_Load(object sender, EventArgs e)
        {
            using (var db = new myDbContext())
            {
                var branch = db.Branches.Find(Branch_ID);
                textBox1.Text = Branch_ID;
                txtAddress.Text = branch.Address;
                txtName.Text = branch.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new myDbContext())
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn lưu những thay đổi không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    var branch = db.Branches.Find(Branch_ID);
                    branch.Name = txtName.Text;
                    branch.Address = txtAddress.Text;
                    db.SaveChanges();
                    MessageBox.Show("Đã Cập Nhật!");
                    this.Dispose();
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn hủy những thay đổi?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Visible = false;
                this.Dispose();
            }
        }
    }
}
