using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryMangementSystem.GUI
{
    public partial class frmEditBranches: Form
    {
        //Variables
        private readonly string BranchId;

        //Constructor
        public frmEditBranches(string branchId)
        {
            InitializeComponent();
            BranchId = branchId;
        }

        private void frmEditBranches_Load(object sender, EventArgs e)
        {

        }
    }
}
