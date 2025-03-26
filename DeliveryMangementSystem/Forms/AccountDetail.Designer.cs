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
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitleRole = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
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
            this.grbDetail.Size = new System.Drawing.Size(423, 320);
            this.grbDetail.TabIndex = 0;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Users Detail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.7347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.2653F));
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleRole, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUserId, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 174);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(153, 131);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 20);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(153, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "label1";
            // 
            // lblTitleRole
            // 
            this.lblTitleRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitleRole.AutoSize = true;
            this.lblTitleRole.BackColor = System.Drawing.Color.White;
            this.lblTitleRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleRole.Location = new System.Drawing.Point(9, 123);
            this.lblTitleRole.Name = "lblTitleRole";
            this.lblTitleRole.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleRole.Size = new System.Drawing.Size(67, 35);
            this.lblTitleRole.TabIndex = 8;
            this.lblTitleRole.Text = "Role:";
            this.lblTitleRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleName
            // 
            this.lblTitleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.BackColor = System.Drawing.Color.White;
            this.lblTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleName.Location = new System.Drawing.Point(9, 69);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleName.Size = new System.Drawing.Size(80, 35);
            this.lblTitleName.TabIndex = 2;
            this.lblTitleName.Text = "Name:";
            this.lblTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleID
            // 
            this.lblTitleID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.BackColor = System.Drawing.Color.White;
            this.lblTitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleID.Location = new System.Drawing.Point(9, 15);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitleID.Size = new System.Drawing.Size(93, 35);
            this.lblTitleID.TabIndex = 0;
            this.lblTitleID.Text = "User ID:";
            this.lblTitleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(153, 22);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(59, 20);
            this.lblUserId.TabIndex = 9;
            this.lblUserId.Text = "label1";
            // 
            // frmAccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 320);
            this.Controls.Add(this.grbDetail);
            this.Name = "frmAccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountDetail";
            this.Load += new System.EventHandler(this.frmAccountDetail_Load_1);
            this.grbDetail.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.Label lblTitleRole;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserId;
    }
}