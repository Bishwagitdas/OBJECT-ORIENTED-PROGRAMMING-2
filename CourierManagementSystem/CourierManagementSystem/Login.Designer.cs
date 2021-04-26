namespace CourierManagementSystem
{
    partial class Login
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
            this.pLogin = new System.Windows.Forms.Panel();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.labelCMS = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUseeId = new System.Windows.Forms.Label();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.Controls.Add(this.txtUserPassword);
            this.pLogin.Controls.Add(this.txtUserId);
            this.pLogin.Controls.Add(this.labelCMS);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.lblPassword);
            this.pLogin.Controls.Add(this.lblUseeId);
            this.pLogin.Location = new System.Drawing.Point(53, 25);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(727, 502);
            this.pLogin.TabIndex = 1;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(277, 242);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(271, 30);
            this.txtUserPassword.TabIndex = 69;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(277, 184);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(271, 30);
            this.txtUserId.TabIndex = 68;
            // 
            // labelCMS
            // 
            this.labelCMS.AutoSize = true;
            this.labelCMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCMS.ForeColor = System.Drawing.Color.Orange;
            this.labelCMS.Location = new System.Drawing.Point(56, 47);
            this.labelCMS.Name = "labelCMS";
            this.labelCMS.Size = new System.Drawing.Size(607, 51);
            this.labelCMS.TabIndex = 11;
            this.labelCMS.Text = "Courier Management System";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(321, 361);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 42);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(122, 243);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 29);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUseeId
            // 
            this.lblUseeId.AutoSize = true;
            this.lblUseeId.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblUseeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseeId.ForeColor = System.Drawing.Color.White;
            this.lblUseeId.Location = new System.Drawing.Point(122, 184);
            this.lblUseeId.Name = "lblUseeId";
            this.lblUseeId.Size = new System.Drawing.Size(139, 29);
            this.lblUseeId.TabIndex = 0;
            this.lblUseeId.Text = "User name";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.pLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginInfo";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label labelCMS;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUseeId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserPassword;
    }
}

