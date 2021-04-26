namespace CourierManagementSystem
{
    partial class AdminStaffSearch
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.pStaffSearch = new System.Windows.Forms.Panel();
            this.dgvStaffSearch = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_blood_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.pStaffSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(190, 40);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(104, 25);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Branch Id";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbPosition.Location = new System.Drawing.Point(303, 35);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(160, 33);
            this.cmbPosition.TabIndex = 12;
            // 
            // pStaffSearch
            // 
            this.pStaffSearch.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pStaffSearch.Controls.Add(this.dgvStaffSearch);
            this.pStaffSearch.Controls.Add(this.btnSearch);
            this.pStaffSearch.Controls.Add(this.lblBack);
            this.pStaffSearch.Controls.Add(this.cmbPosition);
            this.pStaffSearch.Controls.Add(this.lblSearch);
            this.pStaffSearch.Location = new System.Drawing.Point(13, 13);
            this.pStaffSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pStaffSearch.Name = "pStaffSearch";
            this.pStaffSearch.Size = new System.Drawing.Size(806, 527);
            this.pStaffSearch.TabIndex = 52;
            // 
            // dgvStaffSearch
            // 
            this.dgvStaffSearch.AllowUserToAddRows = false;
            this.dgvStaffSearch.AllowUserToDeleteRows = false;
            this.dgvStaffSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_name,
            this.staff_address,
            this.staff_contact,
            this.staff_DOB,
            this.staff_gender,
            this.Staff_qualification,
            this.Staff_blood_group});
            this.dgvStaffSearch.Location = new System.Drawing.Point(0, 178);
            this.dgvStaffSearch.Name = "dgvStaffSearch";
            this.dgvStaffSearch.ReadOnly = true;
            this.dgvStaffSearch.RowHeadersWidth = 15;
            this.dgvStaffSearch.RowTemplate.Height = 24;
            this.dgvStaffSearch.Size = new System.Drawing.Size(800, 350);
            this.dgvStaffSearch.TabIndex = 40;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.Location = new System.Drawing.Point(514, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 33);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // AdminStaffSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pStaffSearch);
            this.Name = "AdminStaffSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStaffSearch";
            this.pStaffSearch.ResumeLayout(false);
            this.pStaffSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Panel pStaffSearch;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStaffSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_blood_group;
    }
}