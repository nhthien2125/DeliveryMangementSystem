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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.tpBranch = new System.Windows.Forms.TabPage();
            this.pnlBranch = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbMenuManager = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmMenuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDetailsOrder = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.tpChangePassword = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridHeaderContainer = new System.Windows.Forms.TableLayoutPanel();
            this.iconBrand = new System.Windows.Forms.PictureBox();
            this.tlpNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBranchManagement = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.tpBranch.SuspendLayout();
            this.pnlBranch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlDetailsOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.gridHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).BeginInit();
            this.tlpNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.CadetBlue;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.54113F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.45888F));
            this.tlpMain.Controls.Add(this.tabControlAdmin, 1, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1161, 590);
            this.tlpMain.TabIndex = 0;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.CausesValidation = false;
            this.tabControlAdmin.Controls.Add(this.tpAccount);
            this.tabControlAdmin.Controls.Add(this.tpBranch);
            this.tabControlAdmin.Controls.Add(this.tpChangePassword);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlAdmin.ItemSize = new System.Drawing.Size(0, 20);
            this.tabControlAdmin.Location = new System.Drawing.Point(307, 20);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(843, 560);
            this.tabControlAdmin.TabIndex = 2;
            // 
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpAccount.Controls.Add(this.tableLayoutPanel1);
            this.tpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpAccount.Location = new System.Drawing.Point(4, 24);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAccount.Size = new System.Drawing.Size(835, 532);
            this.tpAccount.TabIndex = 1;
            this.tpAccount.Text = "Account";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.12111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.87889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeactivate);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeactivate.Location = new System.Drawing.Point(33, 17);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(119, 47);
            this.btnDeactivate.TabIndex = 10;
            this.btnDeactivate.Text = "Restrict";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnActive.Location = new System.Drawing.Point(168, 17);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(119, 47);
            this.btnActive.TabIndex = 9;
            this.btnActive.Text = "Activate";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDetails.Location = new System.Drawing.Point(528, 14);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(119, 47);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(676, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 47);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAccounts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 443);
            this.panel2.TabIndex = 2;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(0, 0);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.Size = new System.Drawing.Size(823, 443);
            this.dgvAccounts.TabIndex = 1;
            // 
            // tpBranch
            // 
            this.tpBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpBranch.Controls.Add(this.pnlBranch);
            this.tpBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpBranch.Location = new System.Drawing.Point(4, 24);
            this.tpBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBranch.Name = "tpBranch";
            this.tpBranch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBranch.Size = new System.Drawing.Size(835, 532);
            this.tpBranch.TabIndex = 2;
            this.tpBranch.Text = "Branch";
            // 
            // pnlBranch
            // 
            this.pnlBranch.Controls.Add(this.tableLayoutPanel3);
            this.pnlBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBranch.Location = new System.Drawing.Point(3, 2);
            this.pnlBranch.Name = "pnlBranch";
            this.pnlBranch.Size = new System.Drawing.Size(829, 528);
            this.pnlBranch.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgvBranches, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.60854F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.39146F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(829, 528);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // dgvBranches
            // 
            this.dgvBranches.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBranches.Location = new System.Drawing.Point(3, 259);
            this.dgvBranches.Name = "dgvBranches";
            this.dgvBranches.RowHeadersWidth = 51;
            this.dgvBranches.RowTemplate.Height = 24;
            this.dgvBranches.Size = new System.Drawing.Size(823, 266);
            this.dgvBranches.TabIndex = 0;
            this.dgvBranches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranches_CellClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.9356F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.0644F));
            this.tableLayoutPanel4.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pnlDetailsOrder, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(823, 250);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.toolStrip1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(83, 244);
            this.pnlMenu.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMenuManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(83, 30);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbMenuManager
            // 
            this.tsbMenuManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMenuManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuManagement});
            this.tsbMenuManager.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbMenuManager.Image = ((System.Drawing.Image)(resources.GetObject("tsbMenuManager.Image")));
            this.tsbMenuManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMenuManager.Name = "tsbMenuManager";
            this.tsbMenuManager.Size = new System.Drawing.Size(62, 27);
            this.tsbMenuManager.Text = "&Tools";
            // 
            // tsmMenuManagement
            // 
            this.tsmMenuManagement.Name = "tsmMenuManagement";
            this.tsmMenuManagement.Size = new System.Drawing.Size(196, 28);
            this.tsmMenuManagement.Text = "&Management";
            // 
            // pnlDetailsOrder
            // 
            this.pnlDetailsOrder.Controls.Add(this.lblDetails);
            this.pnlDetailsOrder.Controls.Add(this.dgvDetails);
            this.pnlDetailsOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsOrder.Location = new System.Drawing.Point(92, 3);
            this.pnlDetailsOrder.Name = "pnlDetailsOrder";
            this.pnlDetailsOrder.Size = new System.Drawing.Size(728, 244);
            this.pnlDetailsOrder.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetails.Location = new System.Drawing.Point(0, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(237, 29);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Bảng chi tiết hóa đơn";
            // 
            // dgvDetails
            // 
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(0, 32);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(728, 212);
            this.dgvDetails.TabIndex = 1;
            // 
            // tpChangePassword
            // 
            this.tpChangePassword.Location = new System.Drawing.Point(4, 24);
            this.tpChangePassword.Name = "tpChangePassword";
            this.tpChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tpChangePassword.Size = new System.Drawing.Size(835, 532);
            this.tpChangePassword.TabIndex = 7;
            this.tpChangePassword.Text = "change";
            this.tpChangePassword.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gridHeaderContainer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tlpNav, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.14537F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.85462F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 584);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // gridHeaderContainer
            // 
            this.gridHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridHeaderContainer.ColumnCount = 2;
            this.gridHeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8209F));
            this.gridHeaderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.17911F));
            this.gridHeaderContainer.Controls.Add(this.iconBrand, 0, 1);
            this.gridHeaderContainer.Controls.Add(this.label1, 1, 1);
            this.gridHeaderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHeaderContainer.Location = new System.Drawing.Point(11, 20);
            this.gridHeaderContainer.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.gridHeaderContainer.Name = "gridHeaderContainer";
            this.gridHeaderContainer.RowCount = 1;
            this.gridHeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gridHeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.84071F));
            this.gridHeaderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gridHeaderContainer.Size = new System.Drawing.Size(268, 93);
            this.gridHeaderContainer.TabIndex = 4;
            // 
            // iconBrand
            // 
            this.iconBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBrand.Image = ((System.Drawing.Image)(resources.GetObject("iconBrand.Image")));
            this.iconBrand.Location = new System.Drawing.Point(3, 2);
            this.iconBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconBrand.Name = "iconBrand";
            this.iconBrand.Size = new System.Drawing.Size(90, 89);
            this.iconBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBrand.TabIndex = 2;
            this.iconBrand.TabStop = false;
            // 
            // tlpNav
            // 
            this.tlpNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tlpNav.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tlpNav.ColumnCount = 1;
            this.tlpNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNav.Controls.Add(this.btnLogOut, 0, 3);
            this.tlpNav.Controls.Add(this.btnChange, 0, 2);
            this.tlpNav.Controls.Add(this.btnBranchManagement, 0, 1);
            this.tlpNav.Controls.Add(this.btnAccountManagement, 0, 0);
            this.tlpNav.Location = new System.Drawing.Point(11, 126);
            this.tlpNav.Name = "tlpNav";
            this.tlpNav.RowCount = 4;
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.Size = new System.Drawing.Size(268, 455);
            this.tlpNav.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLogOut.Location = new System.Drawing.Point(39, 361);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(190, 71);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "↩ Sign Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BackColor = System.Drawing.Color.White;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnChange.Location = new System.Drawing.Point(39, 247);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(190, 71);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "🔐 Change Password";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBranchManagement
            // 
            this.btnBranchManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBranchManagement.BackColor = System.Drawing.Color.White;
            this.btnBranchManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBranchManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBranchManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBranchManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBranchManagement.Location = new System.Drawing.Point(39, 134);
            this.btnBranchManagement.Name = "btnBranchManagement";
            this.btnBranchManagement.Size = new System.Drawing.Size(190, 71);
            this.btnBranchManagement.TabIndex = 1;
            this.btnBranchManagement.Text = "🏢 Branches";
            this.btnBranchManagement.UseVisualStyleBackColor = false;
            this.btnBranchManagement.Click += new System.EventHandler(this.btnBranchManagement_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccountManagement.BackColor = System.Drawing.Color.White;
            this.btnAccountManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAccountManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAccountManagement.Location = new System.Drawing.Point(39, 21);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(190, 71);
            this.btnAccountManagement.TabIndex = 0;
            this.btnAccountManagement.Text = "📋 Accounts";
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(109, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "TL Delivery";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 590);
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load_1);
            this.tlpMain.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.tpBranch.ResumeLayout(false);
            this.pnlBranch.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlDetailsOrder.ResumeLayout(false);
            this.pnlDetailsOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gridHeaderContainer.ResumeLayout(false);
            this.gridHeaderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).EndInit();
            this.tlpNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel gridHeaderContainer;
        private System.Windows.Forms.PictureBox iconBrand;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.TabPage tpChangePassword;
        private System.Windows.Forms.TableLayoutPanel tlpNav;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBranchManagement;
        private System.Windows.Forms.Button btnAccountManagement;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tpBranch;
        private System.Windows.Forms.Panel pnlBranch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvBranches;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbMenuManager;
        private System.Windows.Forms.Panel pnlDetailsOrder;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuManagement;
        private System.Windows.Forms.Label label1;
    }
}