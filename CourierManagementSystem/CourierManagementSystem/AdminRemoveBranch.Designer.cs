namespace CourierManagementSystem
{
    partial class AdminRemoveBranch
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
            this.pRemoveBranch = new System.Windows.Forms.Panel();
            this.dgvStaffSearch = new System.Windows.Forms.DataGridView();
            this.btnRemoveBranch = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.brach_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRemoveBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pRemoveBranch
            // 
            this.pRemoveBranch.Controls.Add(this.dgvStaffSearch);
            this.pRemoveBranch.Controls.Add(this.btnRemoveBranch);
            this.pRemoveBranch.Controls.Add(this.lblBack);
            this.pRemoveBranch.Location = new System.Drawing.Point(12, 12);
            this.pRemoveBranch.Name = "pRemoveBranch";
            this.pRemoveBranch.Size = new System.Drawing.Size(808, 529);
            this.pRemoveBranch.TabIndex = 0;
            // 
            // dgvStaffSearch
            // 
            this.dgvStaffSearch.AllowUserToAddRows = false;
            this.dgvStaffSearch.AllowUserToDeleteRows = false;
            this.dgvStaffSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brach_id,
            this.branch_name,
            this.branch_address,
            this.admin_id});
            this.dgvStaffSearch.Location = new System.Drawing.Point(23, 151);
            this.dgvStaffSearch.Name = "dgvStaffSearch";
            this.dgvStaffSearch.ReadOnly = true;
            this.dgvStaffSearch.RowHeadersWidth = 15;
            this.dgvStaffSearch.RowTemplate.Height = 24;
            this.dgvStaffSearch.Size = new System.Drawing.Size(769, 350);
            this.dgvStaffSearch.TabIndex = 83;
            // 
            // btnRemoveBranch
            // 
            this.btnRemoveBranch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveBranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBranch.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBranch.Location = new System.Drawing.Point(248, 49);
            this.btnRemoveBranch.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveBranch.Name = "btnRemoveBranch";
            this.btnRemoveBranch.Size = new System.Drawing.Size(271, 43);
            this.btnRemoveBranch.TabIndex = 82;
            this.btnRemoveBranch.Text = "Remove branch";
            this.btnRemoveBranch.UseVisualStyleBackColor = false;
            this.btnRemoveBranch.Click += new System.EventHandler(this.btnRemoveBranch_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.White;
            this.lblBack.Image = global::CourierManagementSystem.Properties.Resources.back_arrow;
            this.lblBack.Location = new System.Drawing.Point(0, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(70, 34);
            this.lblBack.TabIndex = 79;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // brach_id
            // 
            this.brach_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brach_id.DataPropertyName = "brach_id";
            this.brach_id.HeaderText = "branch id";
            this.brach_id.MinimumWidth = 6;
            this.brach_id.Name = "brach_id";
            this.brach_id.ReadOnly = true;
            // 
            // branch_name
            // 
            this.branch_name.DataPropertyName = "branch_name";
            this.branch_name.HeaderText = "branch Name";
            this.branch_name.MinimumWidth = 6;
            this.branch_name.Name = "branch_name";
            this.branch_name.ReadOnly = true;
            this.branch_name.Width = 125;
            // 
            // branch_address
            // 
            this.branch_address.DataPropertyName = "branch_address";
            this.branch_address.HeaderText = "address";
            this.branch_address.MinimumWidth = 6;
            this.branch_address.Name = "branch_address";
            this.branch_address.ReadOnly = true;
            this.branch_address.Width = 125;
            // 
            // admin_id
            // 
            this.admin_id.DataPropertyName = "admin_id";
            this.admin_id.HeaderText = "admin_id";
            this.admin_id.MinimumWidth = 6;
            this.admin_id.Name = "admin_id";
            this.admin_id.ReadOnly = true;
            this.admin_id.Width = 125;
            // 
            // AdminRemoveBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pRemoveBranch);
            this.Name = "AdminRemoveBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRemoveBranch";
            this.pRemoveBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pRemoveBranch;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnRemoveBranch;
        private System.Windows.Forms.DataGridView dgvStaffSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn brach_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_id;
    }
}