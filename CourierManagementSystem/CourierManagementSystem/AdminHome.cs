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
    public partial class AdminHome : Form
    {
        private Login Lg { get; set; }
        public AdminHome()
        {
            InitializeComponent();
        }

        public AdminHome(Login lg): this()
        {
            this.Lg = lg;
        }

        private void lblAddStaff_Click(object sender, EventArgs e)
        {
            AdminStaffAdd adminstaffadd = new AdminStaffAdd(this);
            adminstaffadd.Visible = true;
            this.Visible = false;
        }

        private void lblStaffDelete_Click(object sender, EventArgs e)
        {
            AdminStaffDelete adminstaffdelete = new AdminStaffDelete(this);
            adminstaffdelete.Visible = true;
            this.Visible = false;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Lg.Visible = true;
            this.Visible = false;
        }

        private void lblOrderList_Click(object sender, EventArgs e)
        {
            AdminOrderList adminorderlist = new AdminOrderList(this);
            adminorderlist.Visible = true;
            this.Visible = false;
        }

        private void lblRemoveBranch_Click(object sender, EventArgs e)
        {
            AdminRemoveBranch adminremovebranch = new AdminRemoveBranch(this);
            adminremovebranch.Visible = true;
            this.Visible = false;
        }

        private void lblSetSalary_Click(object sender, EventArgs e)
        {
            AdminSetSalary adminsetsalary = new AdminSetSalary(this);
            adminsetsalary.Visible = true;
            this.Visible = false;
        }

        private void lblStaffSearch_Click(object sender, EventArgs e)
        {
            AdminStaffSearch adminstaffsearch = new AdminStaffSearch(this);
            adminstaffsearch.Visible = true;
            this.Visible = false;
        }

        private void lblAddBranch_Click(object sender, EventArgs e)
        {

        }
    }
}
