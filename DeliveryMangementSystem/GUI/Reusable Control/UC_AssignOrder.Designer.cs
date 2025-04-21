namespace DeliveryMangementSystem.GUI.Reusable_Control
{
    partial class UC_AssignOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPendingOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendingOrders
            // 
            this.dgvPendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendingOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvPendingOrders.Name = "dgvPendingOrders";
            this.dgvPendingOrders.RowHeadersWidth = 51;
            this.dgvPendingOrders.RowTemplate.Height = 24;
            this.dgvPendingOrders.Size = new System.Drawing.Size(826, 393);
            this.dgvPendingOrders.TabIndex = 0;
            this.dgvPendingOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingOrders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = " ⮜ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UC_AssignOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPendingOrders);
            this.Name = "UC_AssignOrder";
            this.Size = new System.Drawing.Size(826, 393);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPendingOrders;
        private System.Windows.Forms.Label label1;
    }
}
