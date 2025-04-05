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
            this.tlpNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBranchManagement = new System.Windows.Forms.Button();
            this.btnAccountManagement = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.tpBranch = new System.Windows.Forms.TabPage();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.tpChangePassword = new System.Windows.Forms.TabPage();
            this.tlpMain.SuspendLayout();
            this.grid.SuspendLayout();
            this.gridHeaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).BeginInit();
            this.tlpNav.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.BackColor = System.Drawing.Color.CadetBlue;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.54113F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.45888F));
            this.tlpMain.Controls.Add(this.grid, 0, 0);
            this.tlpMain.Controls.Add(this.tabControlAdmin, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1155, 640);
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
            this.grid.Controls.Add(this.tlpNav, 0, 1);
            this.grid.Location = new System.Drawing.Point(3, 2);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.Name = "grid";
            this.grid.RowCount = 2;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 686F));
            this.grid.Size = new System.Drawing.Size(289, 636);
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
            // tlpNav
            // 
            this.tlpNav.ColumnCount = 1;
            this.tlpNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNav.Controls.Add(this.btnLogOut, 0, 3);
            this.tlpNav.Controls.Add(this.btnChange, 0, 2);
            this.tlpNav.Controls.Add(this.btnBranchManagement, 0, 1);
            this.tlpNav.Controls.Add(this.btnAccountManagement, 0, 0);
            this.tlpNav.Location = new System.Drawing.Point(3, 122);
            this.tlpNav.Name = "tlpNav";
            this.tlpNav.RowCount = 4;
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNav.Size = new System.Drawing.Size(286, 506);
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
            this.btnLogOut.Location = new System.Drawing.Point(48, 406);
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
            this.btnChange.Location = new System.Drawing.Point(48, 279);
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
            this.btnBranchManagement.Location = new System.Drawing.Point(48, 153);
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
            this.btnAccountManagement.Location = new System.Drawing.Point(48, 27);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(190, 71);
            this.btnAccountManagement.TabIndex = 0;
            this.btnAccountManagement.Text = "📋 Accounts";
            this.btnAccountManagement.UseVisualStyleBackColor = false;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click);
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
            this.tabControlAdmin.Controls.Add(this.tpChangePassword);
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlAdmin.ItemSize = new System.Drawing.Size(0, 20);
            this.tabControlAdmin.Location = new System.Drawing.Point(306, 20);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(838, 610);
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
            this.tpAccount.Size = new System.Drawing.Size(830, 582);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 80);
            this.panel1.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDetails.Location = new System.Drawing.Point(526, 14);
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
            this.btnDelete.Location = new System.Drawing.Point(674, 14);
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
            this.panel2.Size = new System.Drawing.Size(818, 486);
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
            this.dgvAccounts.Size = new System.Drawing.Size(818, 486);
            this.dgvAccounts.TabIndex = 1;
            // 
            // tpBranch
            // 
            this.tpBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpBranch.Location = new System.Drawing.Point(4, 24);
            this.tpBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBranch.Name = "tpBranch";
            this.tpBranch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBranch.Size = new System.Drawing.Size(830, 582);
            this.tpBranch.TabIndex = 2;
            this.tpBranch.Text = "Branch";
            // 
            // tpProfile
            // 
            this.tpProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpProfile.Location = new System.Drawing.Point(4, 24);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfile.Size = new System.Drawing.Size(830, 582);
            this.tpProfile.TabIndex = 6;
            this.tpProfile.Text = "Profile";
            // 
            // tpChangePassword
            // 
            this.tpChangePassword.Location = new System.Drawing.Point(4, 24);
            this.tpChangePassword.Name = "tpChangePassword";
            this.tpChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tpChangePassword.Size = new System.Drawing.Size(830, 582);
            this.tpChangePassword.TabIndex = 7;
            this.tpChangePassword.Text = "change";
            this.tpChangePassword.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 640);
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load_1);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grid.ResumeLayout(false);
            this.gridHeaderContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBrand)).EndInit();
            this.tlpNav.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tpProfile;
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
    }
}