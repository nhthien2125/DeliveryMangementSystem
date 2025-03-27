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
            this.nameBrandM = new System.Windows.Forms.Label();
            this.gridNav = new System.Windows.Forms.TableLayoutPanel();
            this.titleLogout = new System.Windows.Forms.Label();
            this.titleBranch = new System.Windows.Forms.Label();
            this.titleAccount = new System.Windows.Forms.Label();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tpBranch = new System.Windows.Forms.TabPage();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.iconBrand = new System.Windows.Forms.PictureBox();
            this.picHRM = new System.Windows.Forms.PictureBox();
            this.picRevenue = new System.Windows.Forms.PictureBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.grid.SuspendLayout();
            this.gridHeaderContainer.SuspendLayout();
            this.gridNav.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.CadetBlue;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Controls.Add(this.grid, 0, 0);
            this.tlpMain.Controls.Add(this.tabControlAdmin, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1183, 573);
            this.tlpMain.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSize = true;
            this.grid.BackColor = System.Drawing.Color.CadetBlue;
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
            this.grid.Size = new System.Drawing.Size(348, 569);
            this.grid.TabIndex = 1;
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
            this.gridNav.Controls.Add(this.titleLogout, 1, 2);
            this.gridNav.Controls.Add(this.titleBranch, 1, 1);
            this.gridNav.Controls.Add(this.picHRM, 0, 1);
            this.gridNav.Controls.Add(this.titleAccount, 1, 0);
            this.gridNav.Controls.Add(this.picRevenue, 0, 2);
            this.gridNav.Controls.Add(this.picContact, 0, 3);
            this.gridNav.Controls.Add(this.picHome, 0, 0);
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
            this.gridNav.Size = new System.Drawing.Size(397, 656);
            this.gridNav.TabIndex = 5;
            // 
            // titleLogout
            // 
            this.titleLogout.AutoSize = true;
            this.titleLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.titleLogout.Location = new System.Drawing.Point(110, 242);
            this.titleLogout.Name = "titleLogout";
            this.titleLogout.Size = new System.Drawing.Size(285, 121);
            this.titleLogout.TabIndex = 15;
            this.titleLogout.Text = "Log Out";
            this.titleLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLogout.Click += new System.EventHandler(this.titleLogout_Click);
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
            this.titleBranch.Click += new System.EventHandler(this.titleBranch_Click);
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
            this.titleAccount.Click += new System.EventHandler(this.titleAccount_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdmin.CausesValidation = false;
            this.tabControlAdmin.Controls.Add(this.tpAccount);
            this.tabControlAdmin.Controls.Add(this.tpBranch);
            this.tabControlAdmin.Controls.Add(this.tpProfile);
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlAdmin.ItemSize = new System.Drawing.Size(0, 20);
            this.tabControlAdmin.Location = new System.Drawing.Point(365, 20);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(807, 543);
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
            this.tpAccount.Size = new System.Drawing.Size(799, 515);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tpBranch
            // 
            this.tpBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpBranch.Location = new System.Drawing.Point(4, 24);
            this.tpBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBranch.Name = "tpBranch";
            this.tpBranch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBranch.Size = new System.Drawing.Size(799, 515);
            this.tpBranch.TabIndex = 2;
            this.tpBranch.Text = "Branch";
            // 
            // tpProfile
            // 
            this.tpProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpProfile.Location = new System.Drawing.Point(4, 24);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfile.Size = new System.Drawing.Size(799, 515);
            this.tpProfile.TabIndex = 6;
            this.tpProfile.Text = "Profile";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 71);
            this.panel1.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDetails.Location = new System.Drawing.Point(510, 14);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(87, 38);
            this.btnDetails.TabIndex = 8;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(603, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(696, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangePassword.Location = new System.Drawing.Point(18, 14);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(245, 38);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.Text = "Change Your Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAccounts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 428);
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
            this.dgvAccounts.Size = new System.Drawing.Size(787, 428);
            this.dgvAccounts.TabIndex = 1;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 573);
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load_1);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grid.ResumeLayout(false);
            this.gridHeaderContainer.ResumeLayout(false);
            this.gridNav.ResumeLayout(false);
            this.gridNav.PerformLayout();
            this.tabControlAdmin.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.TableLayoutPanel gridHeaderContainer;
        private System.Windows.Forms.PictureBox iconBrand;
        private System.Windows.Forms.Label nameBrandM;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tpBranch;
        private System.Windows.Forms.TableLayoutPanel gridNav;
        private System.Windows.Forms.Label titleBranch;
        private System.Windows.Forms.PictureBox picHRM;
        private System.Windows.Forms.Label titleAccount;
        private System.Windows.Forms.PictureBox picRevenue;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.Label titleLogout;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAccounts;
    }
}