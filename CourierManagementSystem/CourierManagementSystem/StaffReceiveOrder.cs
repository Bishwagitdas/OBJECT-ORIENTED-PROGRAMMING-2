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
    public partial class StaffReceiveOrder : Form
    {
        private StaffHome Sth { get; set; }
        public StaffReceiveOrder()
        {
            InitializeComponent();
        }
        public StaffReceiveOrder(StaffHome sth):this()
        {
            this.Sth = sth;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Sth.Visible = true;
            this.Visible = false;
        }
    }
}
