namespace CourierManagementSystem
{
    partial class StaffReleaseOrder
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
            this.pStaffReleaseOrder = new System.Windows.Forms.Panel();
            this.dgvReleaseOrder = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_cus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_cus_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_rec_cus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_rec_cus_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_f_branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_t_branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReleaseOrder = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.pStaffReleaseOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReleaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pStaffReleaseOrder
            // 
            this.pStaffReleaseOrder.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pStaffReleaseOrder.Controls.Add(this.dgvReleaseOrder);
            this.pStaffReleaseOrder.Controls.Add(this.btnReleaseOrder);
            this.pStaffReleaseOrder.Controls.Add(this.lblBack);
            this.pStaffReleaseOrder.Location = new System.Drawing.Point(13, 13);
            this.pStaffReleaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pStaffReleaseOrder.Name = "pStaffReleaseOrder";
            this.pStaffReleaseOrder.Size = new System.Drawing.Size(806, 527);
            this.pStaffReleaseOrder.TabIndex = 54;
            // 
            // dgvReleaseOrder
            // 
            this.dgvReleaseOrder.AllowUserToAddRows = false;
            this.dgvReleaseOrder.AllowUserToDeleteRows = false;
            this.dgvReleaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReleaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.order_cus_name,
            this.order_cus_contact,
            this.order_rec_cus_name,
            this.order_rec_cus_contact,
            this.order_type,
            this.order_quantity,
            this.order_date,
            this.order_f_branch,
            this.order_t_branch,
            this.order_status,
            this.order_amount});
            this.dgvReleaseOrder.Location = new System.Drawing.Point(8, 137);
            this.dgvReleaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReleaseOrder.Name = "dgvReleaseOrder";
            this.dgvReleaseOrder.ReadOnly = true;
            this.dgvReleaseOrder.RowHeadersWidth = 51;
            this.dgvReleaseOrder.Size = new System.Drawing.Size(798, 390);
            this.dgvReleaseOrder.TabIndex = 84;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "order_id";
            this.order_id.MinimumWidth = 6;
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 125;
            // 
            // order_cus_name
            // 
            this.order_cus_name.DataPropertyName = "order_cus_name";
            this.order_cus_name.HeaderText = "Sender Customer Name";
            this.order_cus_name.MinimumWidth = 6;
            this.order_cus_name.Name = "order_cus_name";
            this.order_cus_name.ReadOnly = true;
            this.order_cus_name.Width = 125;
            // 
            // order_cus_contact
            // 
            this.order_cus_contact.DataPropertyName = "order_cus_contact";
            this.order_cus_contact.HeaderText = "Sender Customer Phone";
            this.order_cus_contact.MinimumWidth = 6;
            this.order_cus_contact.Name = "order_cus_contact";
            this.order_cus_contact.ReadOnly = true;
            this.order_cus_contact.Width = 125;
            // 
            // order_rec_cus_name
            // 
            this.order_rec_cus_name.DataPropertyName = "order_rec_cus_name";
            this.order_rec_cus_name.HeaderText = "Rec. Customer Name";
            this.order_rec_cus_name.MinimumWidth = 6;
            this.order_rec_cus_name.Name = "order_rec_cus_name";
            this.order_rec_cus_name.ReadOnly = true;
            this.order_rec_cus_name.Width = 125;
            // 
            // order_rec_cus_contact
            // 
            this.order_rec_cus_contact.DataPropertyName = "order_rec_cus_contact";
            this.order_rec_cus_contact.HeaderText = "Rec. Customer Phone";
            this.order_rec_cus_contact.MinimumWidth = 6;
            this.order_rec_cus_contact.Name = "order_rec_cus_contact";
            this.order_rec_cus_contact.ReadOnly = true;
            this.order_rec_cus_contact.Width = 125;
            // 
            // order_type
            // 
            this.order_type.DataPropertyName = "order_type";
            this.order_type.HeaderText = "Order type";
            this.order_type.MinimumWidth = 6;
            this.order_type.Name = "order_type";
            this.order_type.ReadOnly = true;
            this.order_type.Width = 125;
            // 
            // order_quantity
            // 
            this.order_quantity.DataPropertyName = "order_quantity";
            this.order_quantity.HeaderText = "Quantity";
            this.order_quantity.MinimumWidth = 6;
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.ReadOnly = true;
            this.order_quantity.Width = 125;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "Date";
            this.order_date.MinimumWidth = 6;
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 125;
            // 
            // order_f_branch
            // 
            this.order_f_branch.DataPropertyName = "order_f_branch";
            this.order_f_branch.HeaderText = "From Branch";
            this.order_f_branch.MinimumWidth = 6;
            this.order_f_branch.Name = "order_f_branch";
            this.order_f_branch.ReadOnly = true;
            this.order_f_branch.Width = 125;
            // 
            // order_t_branch
            // 
            this.order_t_branch.DataPropertyName = "order_t_branch";
            this.order_t_branch.HeaderText = "To branch";
            this.order_t_branch.MinimumWidth = 6;
            this.order_t_branch.Name = "order_t_branch";
            this.order_t_branch.ReadOnly = true;
            this.order_t_branch.Width = 125;
            // 
            // order_status
            // 
            this.order_status.DataPropertyName = "order_status";
            this.order_status.HeaderText = "status";
            this.order_status.MinimumWidth = 6;
            this.order_status.Name = "order_status";
            this.order_status.ReadOnly = true;
            this.order_status.Width = 125;
            // 
            // order_amount
            // 
            this.order_amount.DataPropertyName = "order_amount";
            this.order_amount.HeaderText = "Amount";
            this.order_amount.MinimumWidth = 6;
            this.order_amount.Name = "order_amount";
            this.order_amount.ReadOnly = true;
            this.order_amount.Width = 125;
            // 
            // btnReleaseOrder
            // 
            this.btnReleaseOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReleaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReleaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseOrder.ForeColor = System.Drawing.Color.White;
            this.btnReleaseOrder.Location = new System.Drawing.Point(265, 14);
            this.btnReleaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnReleaseOrder.Name = "btnReleaseOrder";
            this.btnReleaseOrder.Size = new System.Drawing.Size(269, 83);
            this.btnReleaseOrder.TabIndex = 83;
            this.btnReleaseOrder.Text = "Release Order";
            this.btnReleaseOrder.UseVisualStyleBackColor = false;
            this.btnReleaseOrder.Click += new System.EventHandler(this.btnReleaseOrder_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.White;
            this.lblBack.Image = global::CourierManagementSystem.Properties.Resources.back_arrow;
            this.lblBack.Location = new System.Drawing.Point(3, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(70, 34);
            this.lblBack.TabIndex = 62;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // StaffReleaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pStaffReleaseOrder);
            this.Name = "StaffReleaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffReleaseOrder";
            this.pStaffReleaseOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReleaseOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pStaffReleaseOrder;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnReleaseOrder;
        private System.Windows.Forms.DataGridView dgvReleaseOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_cus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_cus_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_rec_cus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_rec_cus_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_f_branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_t_branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_amount;
    }
}