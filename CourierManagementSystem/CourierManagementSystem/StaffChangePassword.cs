using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierManagementSystem
{
    public partial class StaffChangePassword : Form
    {
        private StaffHome Sth { get; set; }
        public StaffChangePassword()
        {
            InitializeComponent();
        }
        public StaffChangePassword(StaffHome sth):this()
        {
            this.Sth = sth;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Sth.Visible = true;
            this.Visible = false;
        }

        

        private void btnChange_Click(object sender, EventArgs e)
        {


            DataAccess dataccess = new DataAccess();
            String query = @"UPDATE userlogin SET user_password = '" + this.txtPassword.Text + "' WHERE user_id= '" + this.txtUserId.Text + "';";
            DataSet datase = dataccess.ExecuteQuery(query);

            MessageBox.Show("Update");



        }
    }
}
