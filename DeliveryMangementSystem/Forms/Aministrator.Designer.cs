namespace DeliveryMangementSystem.Forms
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.gridHeaderContainer = new System.Windows.Forms.TableLayoutPanel();
            this.iconBrand = new System.Windows.Forms.PictureBox();
            this.nameBrandM = new System.Windows.Forms.Label();
            this.gridNav = new System.Windows.Forms.TableLayoutPanel();
            this.titleOrder = new System.Windows.Forms.Label();
            this.titleCustomer = new System.Windows.Forms.Label();
            this.titleBranch = new System.Windows.Forms.Label();
            this.picHRM = new System.Windows.Forms.PictureBox();
            this.titleAccount = new System.Windows.Forms.Label();
            this.picRevenue = new System.Windows.Forms.PictureBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AccountPage = new System.Windows.Forms.TabPage();
            this.BranchPage = new System.Windows.Forms.TabPage();
            this.CustomerPage = new System.Windows.Forms.TabPage();
            this.OrderPage = new System.Windows.Forms.TabPage();
            this.ShipperPage = new System.Windows.Forms.TabPage();
            this.LogOutPage = new System.Windows.Forms.TabPage();
            this.tlpMain.SuspendLayout();
            this.grid.SuspendLayout();
            this.gridHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).BeginInit();
            this.gridNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Controls.Add(this.grid, 0, 0);
            this.tlpMain.Controls.Add(this.tabControl1, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1212, 863);
            this.tlpMain.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSize = true;
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.ColumnCount = 2;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.grid.Controls.Add(this.gridHeaderContainer, 0, 0);
            this.grid.Controls.Add(this.gridNav, 0, 1);
            this.grid.Location = new System.Drawing.Point(3, 2);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Name = "grid";
            this.grid.RowCount = 2;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 686F));
            this.grid.Size = new System.Drawing.Size(357, 859);
            this.grid.TabIndex = 1;
            this.grid.Paint += new System.Windows.Forms.PaintEventHandler(this.grid_Paint);
            // 
            // gridHeaderContainer
            // 
            this.gridHeaderContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridHeaderContainer.ColumnCount = 2;
            this.gridHeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.24937F));
            this.gridHeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.75063F));
            this.gridHeaderContainer.Controls.Add(this.iconBrand, 0, 0);
            this.gridHeaderContainer.Controls.Add(this.nameBrandM, 1, 1);
            this.gridHeaderContainer.Location = new System.Drawing.Point(11, 20);
            this.gridHeaderContainer.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.gridHeaderContainer.Name = "gridHeaderContainer";
            this.gridHeaderContainer.RowCount = 1;
            this.gridHeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.41667F));
            this.gridHeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.58333F));
            this.gridHeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gridHeaderContainer.Size = new System.Drawing.Size(397, 89);
            this.gridHeaderContainer.TabIndex = 4;
            // 
            // iconBrand
            // 
            this.iconBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBrand.Location = new System.Drawing.Point(3, 17);
            this.iconBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconBrand.Name = "iconBrand";
            this.gridHeaderContainer.SetRowSpan(this.iconBrand, 2);
            this.iconBrand.Size = new System.Drawing.Size(126, 55);
            this.iconBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBrand.TabIndex = 2;
            this.iconBrand.TabStop = false;
            // 
            // nameBrandM
            // 
            this.nameBrandM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nameBrandM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameBrandM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.nameBrandM.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.nameBrandM.Location = new System.Drawing.Point(135, 31);
            this.nameBrandM.Name = "nameBrandM";
            this.nameBrandM.Size = new System.Drawing.Size(259, 58);
            this.nameBrandM.TabIndex = 1;
            this.nameBrandM.Text = "TL Delivery";
            // 
            // gridNav
            // 
            this.gridNav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNav.ColumnCount = 2;
            this.gridNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.gridNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.gridNav.Controls.Add(this.pictureBox2, 0, 5);
            this.gridNav.Controls.Add(this.titleOrder, 1, 3);
            this.gridNav.Controls.Add(this.titleCustomer, 1, 2);
            this.gridNav.Controls.Add(this.titleBranch, 1, 1);
            this.gridNav.Controls.Add(this.picHRM, 0, 1);
            this.gridNav.Controls.Add(this.titleAccount, 1, 0);
            this.gridNav.Controls.Add(this.picRevenue, 0, 2);
            this.gridNav.Controls.Add(this.picContact, 0, 3);
            this.gridNav.Controls.Add(this.picHome, 0, 0);
            this.gridNav.Controls.Add(this.label1, 1, 4);
            this.gridNav.Controls.Add(this.label2, 1, 5);
            this.gridNav.Controls.Add(this.pictureBox1, 0, 4);
            this.gridNav.Location = new System.Drawing.Point(11, 139);
            this.gridNav.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.gridNav.Name = "gridNav";
            this.gridNav.RowCount = 6;
            this.gridNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.gridNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.gridNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.gridNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.gridNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.gridNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.gridNav.Size = new System.Drawing.Size(397, 710);
            this.gridNav.TabIndex = 5;
            // 
            // titleOrder
            // 
            this.titleOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.titleOrder.ForeColor = System.Drawing.Color.Black;
            this.titleOrder.Location = new System.Drawing.Point(110, 363);
            this.titleOrder.Name = "titleOrder";
            this.titleOrder.Size = new System.Drawing.Size(285, 121);
            this.titleOrder.TabIndex = 8;
            this.titleOrder.Text = "Order Management";
            this.titleOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleCustomer
            // 
            this.titleCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.titleCustomer.ForeColor = System.Drawing.Color.Black;
            this.titleCustomer.Location = new System.Drawing.Point(110, 242);
            this.titleCustomer.Name = "titleCustomer";
            this.titleCustomer.Size = new System.Drawing.Size(285, 121);
            this.titleCustomer.TabIndex = 7;
            this.titleCustomer.Text = "Customer Management";
            this.titleCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleBranch
            // 
            this.titleBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.titleBranch.ForeColor = System.Drawing.Color.Black;
            this.titleBranch.Location = new System.Drawing.Point(110, 121);
            this.titleBranch.Name = "titleBranch";
            this.titleBranch.Size = new System.Drawing.Size(285, 121);
            this.titleBranch.TabIndex = 6;
            this.titleBranch.Text = "Branch Management";
            this.titleBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picHRM
            // 
            this.picHRM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHRM.Location = new System.Drawing.Point(29, 151);
            this.picHRM.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.picHRM.Name = "picHRM";
            this.picHRM.Size = new System.Drawing.Size(49, 61);
            this.picHRM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHRM.TabIndex = 3;
            this.picHRM.TabStop = false;
            // 
            // titleAccount
            // 
            this.titleAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.titleAccount.ForeColor = System.Drawing.Color.Black;
            this.titleAccount.Location = new System.Drawing.Point(110, 0);
            this.titleAccount.Name = "titleAccount";
            this.titleAccount.Size = new System.Drawing.Size(285, 121);
            this.titleAccount.TabIndex = 2;
            this.titleAccount.Text = "Account Management";
            this.titleAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picRevenue
            // 
            this.picRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRevenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRevenue.Location = new System.Drawing.Point(29, 272);
            this.picRevenue.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.picRevenue.Name = "picRevenue";
            this.picRevenue.Size = new System.Drawing.Size(49, 61);
            this.picRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRevenue.TabIndex = 4;
            this.picRevenue.TabStop = false;
            // 
            // picContact
            // 
            this.picContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picContact.Location = new System.Drawing.Point(29, 393);
            this.picContact.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(49, 61);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContact.TabIndex = 5;
            this.picContact.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Location = new System.Drawing.Point(30, 30);
            this.picHome.Margin = new System.Windows.Forms.Padding(30);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(47, 61);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(110, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 121);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shipper Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(110, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 105);
            this.label2.TabIndex = 10;
            this.label2.Text = "Log Out";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 514);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(29, 635);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.AccountPage);
            this.tabControl1.Controls.Add(this.BranchPage);
            this.tabControl1.Controls.Add(this.CustomerPage);
            this.tabControl1.Controls.Add(this.OrderPage);
            this.tabControl1.Controls.Add(this.ShipperPage);
            this.tabControl1.Controls.Add(this.LogOutPage);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(374, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 833);
            this.tabControl1.TabIndex = 2;
            // 
            // AccountPage
            // 
            this.AccountPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AccountPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AccountPage.Location = new System.Drawing.Point(4, 4);
            this.AccountPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountPage.Name = "AccountPage";
            this.AccountPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountPage.Size = new System.Drawing.Size(820, 815);
            this.AccountPage.TabIndex = 0;
            this.AccountPage.Text = "Account";
            // 
            // BranchPage
            // 
            this.BranchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BranchPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BranchPage.Location = new System.Drawing.Point(4, 4);
            this.BranchPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BranchPage.Name = "BranchPage";
            this.BranchPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BranchPage.Size = new System.Drawing.Size(819, 824);
            this.BranchPage.TabIndex = 1;
            this.BranchPage.Text = "Branch";
            // 
            // CustomerPage
            // 
            this.CustomerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CustomerPage.Location = new System.Drawing.Point(4, 4);
            this.CustomerPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerPage.Name = "CustomerPage";
            this.CustomerPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerPage.Size = new System.Drawing.Size(820, 815);
            this.CustomerPage.TabIndex = 2;
            this.CustomerPage.Text = "Customer";
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderPage.Location = new System.Drawing.Point(4, 4);
            this.OrderPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderPage.Size = new System.Drawing.Size(820, 815);
            this.OrderPage.TabIndex = 3;
            this.OrderPage.Text = "Order";
            // 
            // ShipperPage
            // 
            this.ShipperPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ShipperPage.Location = new System.Drawing.Point(4, 4);
            this.ShipperPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShipperPage.Name = "ShipperPage";
            this.ShipperPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShipperPage.Size = new System.Drawing.Size(820, 815);
            this.ShipperPage.TabIndex = 4;
            this.ShipperPage.Text = "Shipper";
            // 
            // LogOutPage
            // 
            this.LogOutPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogOutPage.Location = new System.Drawing.Point(4, 4);
            this.LogOutPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutPage.Name = "LogOutPage";
            this.LogOutPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutPage.Size = new System.Drawing.Size(820, 815);
            this.LogOutPage.TabIndex = 5;
            this.LogOutPage.Text = "LogOut";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 863);
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grid.ResumeLayout(false);
            this.gridHeaderContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).EndInit();
            this.gridNav.ResumeLayout(false);
            this.gridNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.TableLayoutPanel gridHeaderContainer;
        private System.Windows.Forms.PictureBox iconBrand;
        private System.Windows.Forms.Label nameBrandM;
        private System.Windows.Forms.TableLayoutPanel gridNav;
        private System.Windows.Forms.Label titleOrder;
        private System.Windows.Forms.Label titleCustomer;
        private System.Windows.Forms.Label titleBranch;
        private System.Windows.Forms.PictureBox picHRM;
        private System.Windows.Forms.Label titleAccount;
        private System.Windows.Forms.PictureBox picRevenue;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AccountPage;
        private System.Windows.Forms.TabPage BranchPage;
        private System.Windows.Forms.TabPage CustomerPage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.TabPage ShipperPage;
        private System.Windows.Forms.TabPage LogOutPage;
    }
}