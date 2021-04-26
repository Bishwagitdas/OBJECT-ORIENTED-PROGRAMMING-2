namespace CourierManagementSystem
{
    partial class StaffChangePassword
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
            this.pStaffChangePassword = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pStaffChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStaffChangePassword
            // 
            this.pStaffChangePassword.Controls.Add(this.txtPassword);
            this.pStaffChangePassword.Controls.Add(this.txtUserId);
            this.pStaffChangePassword.Controls.Add(this.btnChange);
            this.pStaffChangePassword.Controls.Add(this.lblNewPassword);
            this.pStaffChangePassword.Controls.Add(this.lblUserId);
            this.pStaffChangePassword.Controls.Add(this.lblBack);
            this.pStaffChangePassword.Location = new System.Drawing.Point(12, 12);
            this.pStaffChangePassword.Name = "pStaffChangePassword";
            this.pStaffChangePassword.Size = new System.Drawing.Size(808, 529);
            this.pStaffChangePassword.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Orange;
            this.btnChange.Location = new System.Drawing.Point(329, 340);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(126, 30);
            this.btnChange.TabIndex = 111;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(111, 225);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(148, 24);
            this.lblNewPassword.TabIndex = 109;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(111, 164);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(76, 24);
            this.lblUserId.TabIndex = 97;
            this.lblUserId.Text = "User Id";
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.White;
            this.lblBack.Image = global::CourierManagementSystem.Properties.Resources.back_arrow;
            this.lblBack.Location = new System.Drawing.Point(0, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(70, 34);
            this.lblBack.TabIndex = 64;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(289, 159);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(271, 30);
            this.txtUserId.TabIndex = 112;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(289, 220);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 30);
            this.txtPassword.TabIndex = 113;
            // 
            // StaffChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pStaffChangePassword);
            this.Name = "StaffChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffChangePassword";
            this.pStaffChangePassword.ResumeLayout(false);
            this.pStaffChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pStaffChangePassword;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
    }
}