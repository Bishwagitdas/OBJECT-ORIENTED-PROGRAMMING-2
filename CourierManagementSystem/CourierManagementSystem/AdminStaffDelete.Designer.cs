namespace CourierManagementSystem
{
    partial class AdminStaffDelete
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
            this.pDeleteStaff = new System.Windows.Forms.Panel();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.dgvStaffSearch = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_blood_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDeleteStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pDeleteStaff
            // 
            this.pDeleteStaff.Controls.Add(this.dgvStaffSearch);
            this.pDeleteStaff.Controls.Add(this.btnStaffDelete);
            this.pDeleteStaff.Controls.Add(this.lblBack);
            this.pDeleteStaff.Location = new System.Drawing.Point(12, 12);
            this.pDeleteStaff.Name = "pDeleteStaff";
            this.pDeleteStaff.Size = new System.Drawing.Size(808, 529);
            this.pDeleteStaff.TabIndex = 0;
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStaffDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDelete.ForeColor = System.Drawing.Color.White;
            this.btnStaffDelete.Location = new System.Drawing.Point(269, 62);
            this.btnStaffDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(271, 43);
            this.btnStaffDelete.TabIndex = 72;
            this.btnStaffDelete.Text = "Delete Staff";
            this.btnStaffDelete.UseVisualStyleBackColor = false;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.White;
            this.lblBack.Image = global::CourierManagementSystem.Properties.Resources.back_arrow;
            this.lblBack.Location = new System.Drawing.Point(3, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(70, 34);
            this.lblBack.TabIndex = 61;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // dgvStaffSearch
            // 
            this.dgvStaffSearch.AllowUserToAddRows = false;
            this.dgvStaffSearch.AllowUserToDeleteRows = false;
            this.dgvStaffSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.admin_id,
            this.user_id,
            this.branch_id,
            this.staff_name,
            this.staff_address,
            this.staff_contact,
            this.staff_DOB,
            this.staff_gender,
            this.Staff_qualification,
            this.Staff_blood_group});
            this.dgvStaffSearch.Location = new System.Drawing.Point(5, 179);
            this.dgvStaffSearch.Name = "dgvStaffSearch";
            this.dgvStaffSearch.ReadOnly = true;
            this.dgvStaffSearch.RowHeadersWidth = 15;
            this.dgvStaffSearch.RowTemplate.Height = 24;
            this.dgvStaffSearch.Size = new System.Drawing.Size(800, 350);
            this.dgvStaffSearch.TabIndex = 73;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "Staff id";
            this.staff_id.MinimumWidth = 6;
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            this.staff_id.Width = 125;
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
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Width = 125;
            // 
            // branch_id
            // 
            this.branch_id.DataPropertyName = "branch_id";
            this.branch_id.HeaderText = "branch_id";
            this.branch_id.MinimumWidth = 6;
            this.branch_id.Name = "branch_id";
            this.branch_id.ReadOnly = true;
            this.branch_id.Width = 125;
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "Name";
            this.staff_name.MinimumWidth = 6;
            this.staff_name.Name = "staff_name";
            this.staff_name.ReadOnly = true;
            this.staff_name.Width = 125;
            // 
            // staff_address
            // 
            this.staff_address.DataPropertyName = "staff_address";
            this.staff_address.HeaderText = "Address";
            this.staff_address.MinimumWidth = 6;
            this.staff_address.Name = "staff_address";
            this.staff_address.ReadOnly = true;
            this.staff_address.Width = 125;
            // 
            // staff_contact
            // 
            this.staff_contact.DataPropertyName = "staff_contact";
            this.staff_contact.HeaderText = "Phone";
            this.staff_contact.MinimumWidth = 6;
            this.staff_contact.Name = "staff_contact";
            this.staff_contact.ReadOnly = true;
            this.staff_contact.Width = 125;
            // 
            // staff_DOB
            // 
            this.staff_DOB.DataPropertyName = "staff_DOB";
            this.staff_DOB.HeaderText = "Date of Birth";
            this.staff_DOB.MinimumWidth = 6;
            this.staff_DOB.Name = "staff_DOB";
            this.staff_DOB.ReadOnly = true;
            this.staff_DOB.Width = 125;
            // 
            // staff_gender
            // 
            this.staff_gender.DataPropertyName = "staff_gender";
            this.staff_gender.HeaderText = "Gender";
            this.staff_gender.MinimumWidth = 6;
            this.staff_gender.Name = "staff_gender";
            this.staff_gender.ReadOnly = true;
            this.staff_gender.Width = 125;
            // 
            // Staff_qualification
            // 
            this.Staff_qualification.DataPropertyName = "staff_qualification";
            this.Staff_qualification.HeaderText = "Qualification";
            this.Staff_qualification.MinimumWidth = 6;
            this.Staff_qualification.Name = "Staff_qualification";
            this.Staff_qualification.ReadOnly = true;
            this.Staff_qualification.Width = 125;
            // 
            // Staff_blood_group
            // 
            this.Staff_blood_group.DataPropertyName = "staff_blood_group";
            this.Staff_blood_group.HeaderText = "Blood Group";
            this.Staff_blood_group.MinimumWidth = 6;
            this.Staff_blood_group.Name = "Staff_blood_group";
            this.Staff_blood_group.ReadOnly = true;
            this.Staff_blood_group.Width = 125;
            // 
            // AdminStaffDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pDeleteStaff);
            this.Name = "AdminStaffDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStaffDelete";
            this.pDeleteStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDeleteStaff;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.DataGridView dgvStaffSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_blood_group;
    }
}