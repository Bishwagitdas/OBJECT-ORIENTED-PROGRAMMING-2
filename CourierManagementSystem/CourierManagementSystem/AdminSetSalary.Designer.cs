namespace CourierManagementSystem
{
    partial class AdminSetSalary
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
            this.pSetSalary = new System.Windows.Forms.Panel();
            this.lblSalaryId = new System.Windows.Forms.Label();
            this.txtSalaryId = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnSetSalary = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.dgvStaffSearch = new System.Windows.Forms.DataGridView();
            this.salary_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSetSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pSetSalary
            // 
            this.pSetSalary.Controls.Add(this.dgvStaffSearch);
            this.pSetSalary.Controls.Add(this.lblSalaryId);
            this.pSetSalary.Controls.Add(this.txtSalaryId);
            this.pSetSalary.Controls.Add(this.lblBack);
            this.pSetSalary.Controls.Add(this.btnSetSalary);
            this.pSetSalary.Controls.Add(this.txtBonus);
            this.pSetSalary.Controls.Add(this.txtSalary);
            this.pSetSalary.Controls.Add(this.lblBonus);
            this.pSetSalary.Controls.Add(this.lblSalary);
            this.pSetSalary.Controls.Add(this.txtStaffId);
            this.pSetSalary.Controls.Add(this.lblStaffId);
            this.pSetSalary.Location = new System.Drawing.Point(12, 12);
            this.pSetSalary.Name = "pSetSalary";
            this.pSetSalary.Size = new System.Drawing.Size(808, 529);
            this.pSetSalary.TabIndex = 0;
            // 
            // lblSalaryId
            // 
            this.lblSalaryId.AutoSize = true;
            this.lblSalaryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryId.ForeColor = System.Drawing.Color.White;
            this.lblSalaryId.Location = new System.Drawing.Point(92, 38);
            this.lblSalaryId.Name = "lblSalaryId";
            this.lblSalaryId.Size = new System.Drawing.Size(90, 24);
            this.lblSalaryId.TabIndex = 77;
            this.lblSalaryId.Text = "Salary Id";
            // 
            // txtSalaryId
            // 
            this.txtSalaryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryId.Location = new System.Drawing.Point(229, 33);
            this.txtSalaryId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalaryId.Name = "txtSalaryId";
            this.txtSalaryId.Size = new System.Drawing.Size(271, 30);
            this.txtSalaryId.TabIndex = 76;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.White;
            this.lblBack.Image = global::CourierManagementSystem.Properties.Resources.back_arrow;
            this.lblBack.Location = new System.Drawing.Point(3, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(70, 34);
            this.lblBack.TabIndex = 75;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnSetSalary
            // 
            this.btnSetSalary.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSetSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSalary.ForeColor = System.Drawing.Color.White;
            this.btnSetSalary.Location = new System.Drawing.Point(559, 76);
            this.btnSetSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetSalary.Name = "btnSetSalary";
            this.btnSetSalary.Size = new System.Drawing.Size(201, 43);
            this.btnSetSalary.TabIndex = 74;
            this.btnSetSalary.Text = "Set Salary";
            this.btnSetSalary.UseVisualStyleBackColor = false;
            this.btnSetSalary.Click += new System.EventHandler(this.btnSetSalary_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(229, 147);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(271, 30);
            this.txtBonus.TabIndex = 73;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(229, 109);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(271, 30);
            this.txtSalary.TabIndex = 72;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.Color.White;
            this.lblBonus.Location = new System.Drawing.Point(92, 152);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(69, 24);
            this.lblBonus.TabIndex = 71;
            this.lblBonus.Text = "Bonus";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(92, 114);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(67, 24);
            this.lblSalary.TabIndex = 70;
            this.lblSalary.Text = "Salary";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffId.Location = new System.Drawing.Point(229, 71);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(271, 30);
            this.txtStaffId.TabIndex = 69;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffId.ForeColor = System.Drawing.Color.White;
            this.lblStaffId.Location = new System.Drawing.Point(92, 76);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(72, 24);
            this.lblStaffId.TabIndex = 64;
            this.lblStaffId.Text = "Staff Id";
            // 
            // dgvStaffSearch
            // 
            this.dgvStaffSearch.AllowUserToAddRows = false;
            this.dgvStaffSearch.AllowUserToDeleteRows = false;
            this.dgvStaffSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salary_id,
            this.salary_amount,
            this.salary_bonus,
            this.staff_id});
            this.dgvStaffSearch.Location = new System.Drawing.Point(3, 216);
            this.dgvStaffSearch.Name = "dgvStaffSearch";
            this.dgvStaffSearch.ReadOnly = true;
            this.dgvStaffSearch.RowHeadersWidth = 15;
            this.dgvStaffSearch.RowTemplate.Height = 24;
            this.dgvStaffSearch.Size = new System.Drawing.Size(799, 310);
            this.dgvStaffSearch.TabIndex = 84;
            // 
            // salary_id
            // 
            this.salary_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary_id.DataPropertyName = "salary_id";
            this.salary_id.HeaderText = "salary_id";
            this.salary_id.MinimumWidth = 6;
            this.salary_id.Name = "salary_id";
            this.salary_id.ReadOnly = true;
            // 
            // salary_amount
            // 
            this.salary_amount.DataPropertyName = "salary_amount";
            this.salary_amount.HeaderText = "salary";
            this.salary_amount.MinimumWidth = 6;
            this.salary_amount.Name = "salary_amount";
            this.salary_amount.ReadOnly = true;
            this.salary_amount.Width = 125;
            // 
            // salary_bonus
            // 
            this.salary_bonus.DataPropertyName = "salary_bonus";
            this.salary_bonus.HeaderText = "bonus";
            this.salary_bonus.MinimumWidth = 6;
            this.salary_bonus.Name = "salary_bonus";
            this.salary_bonus.ReadOnly = true;
            this.salary_bonus.Width = 125;
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "staff id";
            this.staff_id.MinimumWidth = 6;
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            this.staff_id.Width = 125;
            // 
            // AdminSetSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pSetSalary);
            this.Name = "AdminSetSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSetSalary";
            this.pSetSalary.ResumeLayout(false);
            this.pSetSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSetSalary;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSetSalary;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblSalaryId;
        private System.Windows.Forms.TextBox txtSalaryId;
        private System.Windows.Forms.DataGridView dgvStaffSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
    }
}