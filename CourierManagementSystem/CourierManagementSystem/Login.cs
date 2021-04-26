using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourierManagementSystem 
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess dataccess = new DataAccess();
            string query = @"select * from userlogin where user_id = '" + this.txtUserId.Text + "' and user_password = '" + this.txtUserPassword.Text + "';";
            DataSet datase = dataccess.ExecuteQuery(query);
            if (datase.Tables[0].Rows.Count == 1)
            {
                if (datase.Tables[0].Rows[0][3].ToString() == "admin")
                {
                    AdminHome adminHome = new AdminHome(this);
                    adminHome.Visible = true;
                    this.Visible = false; 
                }
                else
                {
                    StaffHome staffHome = new StaffHome(this);
                    staffHome.Visible = true;
                    this.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("UserName or Password is not correct!!!");
            }

        }
    }
}
