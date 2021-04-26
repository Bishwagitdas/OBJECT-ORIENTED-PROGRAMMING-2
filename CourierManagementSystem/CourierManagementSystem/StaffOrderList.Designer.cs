namespace CourierManagementSystem
{
    partial class StaffOrderList
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
            this.pOrderList = new System.Windows.Forms.Panel();
            this.dgvShowOrder = new System.Windows.Forms.DataGridView();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pOrderList
            // 
            this.pOrderList.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pOrderList.Controls.Add(this.dgvShowOrder);
            this.pOrderList.Controls.Add(this.btnSearch);
            this.pOrderList.Controls.Add(this.cmbPosition);
            this.pOrderList.Controls.Add(this.lblStatus);
            this.pOrderList.Controls.Add(this.lblBack);
            this.pOrderList.Location = new System.Drawing.Point(13, 13);
            this.pOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.pOrderList.Name = "pOrderList";
            this.pOrderList.Size = new System.Drawing.Size(806, 527);
            this.pOrderList.TabIndex = 54;
            // 
            // dgvShowOrder
            // 
            this.dgvShowOrder.AllowUserToAddRows = false;
            this.dgvShowOrder.AllowUserToDeleteRows = false;
            this.dgvShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvShowOrder.Location = new System.Drawing.Point(4, 137);
            this.dgvShowOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShowOrder.Name = "dgvShowOrder";
            this.dgvShowOrder.ReadOnly = true;
            this.dgvShowOrder.RowHeadersWidth = 51;
            this.dgvShowOrder.Size = new System.Drawing.Size(798, 390);
            this.dgvShowOrder.TabIndex = 68;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.Location = new System.Drawing.Point(508, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 33);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Comfirm",
            "Release"});
            this.cmbPosition.Location = new System.Drawing.Point(246, 44);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(160, 33);
            this.cmbPosition.TabIndex = 66;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(158, 49);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 65;
            this.lblStatus.Text = "Order ";
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
            // StaffOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pOrderList);
            this.Name = "StaffOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffOrderList";
            this.pOrderList.ResumeLayout(false);
            this.pOrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pOrderList;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvShowOrder;
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