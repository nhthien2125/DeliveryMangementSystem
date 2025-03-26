namespace DeliveryMangementSystem.Forms
{
    partial class frmAccountDetail
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
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblTitlePhone = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTitleEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitleRole = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.grbDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetail
            // 
            this.grbDetail.BackColor = System.Drawing.Color.White;
            this.grbDetail.Controls.Add(this.tableLayoutPanel1);
            this.grbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbDetail.Location = new System.Drawing.Point(0, 0);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Padding = new System.Windows.Forms.Padding(10);
            this.grbDetail.Size = new System.Drawing.Size(423, 529);
            this.grbDetail.TabIndex = 0;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Account Detail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleRole, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitlePhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAccountName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAccountID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleID, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.BackColor = System.Drawing.Color.White;
            this.lblTitleID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleID.Location = new System.Drawing.Point(9, 6);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleID.Size = new System.Drawing.Size(189, 94);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "Account ID:";
            this.lblTitleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.BackColor = System.Drawing.Color.White;
            this.lblAccountID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAccountID.Location = new System.Drawing.Point(205, 6);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Padding = new System.Windows.Forms.Padding(5);
            this.lblAccountID.Size = new System.Drawing.Size(189, 94);
            this.lblAccountID.TabIndex = 1;
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.BackColor = System.Drawing.Color.White;
            this.lblTitleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleName.Location = new System.Drawing.Point(9, 101);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleName.Size = new System.Drawing.Size(189, 94);
            this.lblTitleName.TabIndex = 2;
            this.lblTitleName.Text = "Name:";
            this.lblTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.BackColor = System.Drawing.Color.White;
            this.lblAccountName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAccountName.Location = new System.Drawing.Point(205, 101);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Padding = new System.Windows.Forms.Padding(5);
            this.lblAccountName.Size = new System.Drawing.Size(189, 94);
            this.lblAccountName.TabIndex = 3;
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitlePhone
            // 
            this.lblTitlePhone.AutoSize = true;
            this.lblTitlePhone.BackColor = System.Drawing.Color.White;
            this.lblTitlePhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitlePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitlePhone.Location = new System.Drawing.Point(9, 196);
            this.lblTitlePhone.Name = "lblTitlePhone";
            this.lblTitlePhone.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitlePhone.Size = new System.Drawing.Size(189, 94);
            this.lblTitlePhone.TabIndex = 4;
            this.lblTitlePhone.Text = "Phone:";
            this.lblTitlePhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhone.Location = new System.Drawing.Point(205, 196);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(5);
            this.lblPhone.Size = new System.Drawing.Size(189, 94);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleEmail
            // 
            this.lblTitleEmail.AutoSize = true;
            this.lblTitleEmail.BackColor = System.Drawing.Color.White;
            this.lblTitleEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleEmail.Location = new System.Drawing.Point(9, 291);
            this.lblTitleEmail.Name = "lblTitleEmail";
            this.lblTitleEmail.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleEmail.Size = new System.Drawing.Size(189, 94);
            this.lblTitleEmail.TabIndex = 6;
            this.lblTitleEmail.Text = "Email:";
            this.lblTitleEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(205, 291);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(5);
            this.lblEmail.Size = new System.Drawing.Size(189, 94);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleRole
            // 
            this.lblTitleRole.AutoSize = true;
            this.lblTitleRole.BackColor = System.Drawing.Color.White;
            this.lblTitleRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleRole.Location = new System.Drawing.Point(9, 386);
            this.lblTitleRole.Name = "lblTitleRole";
            this.lblTitleRole.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleRole.Size = new System.Drawing.Size(189, 97);
            this.lblTitleRole.TabIndex = 8;
            this.lblTitleRole.Text = "Role:";
            this.lblTitleRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.White;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(205, 386);
            this.lblRole.Name = "lblRole";
            this.lblRole.Padding = new System.Windows.Forms.Padding(5);
            this.lblRole.Size = new System.Drawing.Size(189, 97);
            this.lblRole.TabIndex = 9;
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 529);
            this.Controls.Add(this.grbDetail);
            this.Name = "frmAccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountDetail";
            this.grbDetail.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTitleRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitleEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTitlePhone;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblAccountID;
    }
}