namespace CourierManagementSystem
{
    partial class AdminHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.pAdminHome = new System.Windows.Forms.Panel();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblRemoveBranch = new System.Windows.Forms.Label();
            this.lblSetSalary = new System.Windows.Forms.Label();
            this.lblStaffSearch = new System.Windows.Forms.Label();
            this.lblStaffDelete = new System.Windows.Forms.Label();
            this.lblAddStaff = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblAdminHome = new System.Windows.Forms.Label();
            this.pAdminHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pAdminHome
            // 
            this.pAdminHome.Controls.Add(this.lblOrderList);
            this.pAdminHome.Controls.Add(this.lblRemoveBranch);
            this.pAdminHome.Controls.Add(this.lblSetSalary);
            this.pAdminHome.Controls.Add(this.lblStaffSearch);
            this.pAdminHome.Controls.Add(this.lblStaffDelete);
            this.pAdminHome.Controls.Add(this.lblAddStaff);
            this.pAdminHome.Controls.Add(this.lblLogOut);
            this.pAdminHome.Controls.Add(this.lblAdminHome);
            this.pAdminHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAdminHome.ForeColor = System.Drawing.Color.White;
            this.pAdminHome.Location = new System.Drawing.Point(12, 12);
            this.pAdminHome.Name = "pAdminHome";
            this.pAdminHome.Size = new System.Drawing.Size(808, 529);
            this.pAdminHome.TabIndex = 0;
            // 
            // lblOrderList
            // 
            this.lblOrderList.BackColor = System.Drawing.Color.Orange;
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.Location = new System.Drawing.Point(607, 346);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(164, 62);
            this.lblOrderList.TabIndex = 67;
            this.lblOrderList.Text = "Order List";
            this.lblOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderList.Click += new System.EventHandler(this.lblOrderList_Click);
            // 
            // lblRemoveBranch
            // 
            this.lblRemoveBranch.BackColor = System.Drawing.Color.Orange;
            this.lblRemoveBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveBranch.Location = new System.Drawing.Point(326, 346);
            this.lblRemoveBranch.Name = "lblRemoveBranch";
            this.lblRemoveBranch.Size = new System.Drawing.Size(164, 62);
            this.lblRemoveBranch.TabIndex = 65;
            this.lblRemoveBranch.Text = "Remove Branch";
            this.lblRemoveBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemoveBranch.Click += new System.EventHandler(this.lblRemoveBranch_Click);
            // 
            // lblSetSalary
            // 
            this.lblSetSalary.BackColor = System.Drawing.Color.Orange;
            this.lblSetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetSalary.Location = new System.Drawing.Point(36, 346);
            this.lblSetSalary.Name = "lblSetSalary";
            this.lblSetSalary.Size = new System.Drawing.Size(164, 62);
            this.lblSetSalary.TabIndex = 64;
            this.lblSetSalary.Text = "Set Salary";
            this.lblSetSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSetSalary.Click += new System.EventHandler(this.lblSetSalary_Click);
            // 
            // lblStaffSearch
            // 
            this.lblStaffSearch.BackColor = System.Drawing.Color.Orange;
            this.lblStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSearch.Location = new System.Drawing.Point(607, 256);
            this.lblStaffSearch.Name = "lblStaffSearch";
            this.lblStaffSearch.Size = new System.Drawing.Size(164, 62);
            this.lblStaffSearch.TabIndex = 63;
            this.lblStaffSearch.Text = "Staff Search";
            this.lblStaffSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaffSearch.Click += new System.EventHandler(this.lblStaffSearch_Click);
            // 
            // lblStaffDelete
            // 
            this.lblStaffDelete.BackColor = System.Drawing.Color.Orange;
            this.lblStaffDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDelete.Location = new System.Drawing.Point(322, 256);
            this.lblStaffDelete.Name = "lblStaffDelete";
            this.lblStaffDelete.Size = new System.Drawing.Size(164, 62);
            this.lblStaffDelete.TabIndex = 62;
            this.lblStaffDelete.Text = "Staff Delete";
            this.lblStaffDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStaffDelete.Click += new System.EventHandler(this.lblStaffDelete_Click);
            // 
            // lblAddStaff
            // 
            this.lblAddStaff.BackColor = System.Drawing.Color.Orange;
            this.lblAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStaff.Location = new System.Drawing.Point(36, 256);
            this.lblAddStaff.Name = "lblAddStaff";
            this.lblAddStaff.Size = new System.Drawing.Size(164, 62);
            this.lblAddStaff.TabIndex = 61;
            this.lblAddStaff.Text = "Staff Add";
            this.lblAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddStaff.Click += new System.EventHandler(this.lblAddStaff_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.Location = new System.Drawing.Point(448, 75);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(89, 25);
            this.lblLogOut.TabIndex = 60;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // lblAdminHome
            // 
            this.lblAdminHome.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAdminHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAdminHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHome.Image = global::CourierManagementSystem.Properties.Resources.admin_p;
            this.lblAdminHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAdminHome.Location = new System.Drawing.Point(237, 18);
            this.lblAdminHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminHome.Name = "lblAdminHome";
            this.lblAdminHome.Size = new System.Drawing.Size(192, 154);
            this.lblAdminHome.TabIndex = 50;
            this.lblAdminHome.Text = "  ";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pAdminHome);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.pAdminHome.ResumeLayout(false);
            this.pAdminHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminHome;
        private System.Windows.Forms.Panel pAdminHome;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Label lblRemoveBranch;
        private System.Windows.Forms.Label lblSetSalary;
        private System.Windows.Forms.Label lblStaffSearch;
        private System.Windows.Forms.Label lblStaffDelete;
        private System.Windows.Forms.Label lblAddStaff;
    }
}