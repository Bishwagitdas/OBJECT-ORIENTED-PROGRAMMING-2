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
    public partial class AdminStaffAdd : Form
    {
        private AdminHome Adm { get; set; }
        public AdminStaffAdd()
        {
            InitializeComponent();
        }
        public AdminStaffAdd(AdminHome adm):this()
        {
            this.Adm = adm;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Adm.Visible = true;
            this.Visible = false;
        }
    }
}
