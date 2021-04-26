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
    public partial class StaffHome : Form
    {
        private Login Lg { get; set; }
        public StaffHome()
        {
            InitializeComponent();
        }

        public StaffHome(Login lg):this()
        {
            this.Lg = lg;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Lg.Visible = true;
            this.Visible = false;
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            StaffChangePassword staffchangepassword = new StaffChangePassword(this);
            staffchangepassword.Visible = true;
            this.Visible = false;
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            StaffEditProfile staffeditprofile = new StaffEditProfile(this);
            staffeditprofile.Visible = true;
            this.Visible = false;
        }

        private void lblShowOrderList_Click(object sender, EventArgs e)
        {
            StaffOrderList stafforderlist = new StaffOrderList(this);
            stafforderlist.Visible = true;
            this.Visible = false;
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            StaffPayment staffpayment = new StaffPayment(this);
            staffpayment.Visible = true;
            this.Visible = false;
        }

        private void lblReleaseOrder_Click(object sender, EventArgs e)
        {
            StaffReleaseOrder staffreleaseorder = new StaffReleaseOrder(this);
            staffreleaseorder.Visible = true;
            this.Visible = false;
        }

        private void lblReceiveOrder_Click(object sender, EventArgs e)
        {
            StaffReceiveOrder staffreceiveorder = new StaffReceiveOrder(this);
            staffreceiveorder.Visible = true;
            this.Visible = false;
        }
    }
}
