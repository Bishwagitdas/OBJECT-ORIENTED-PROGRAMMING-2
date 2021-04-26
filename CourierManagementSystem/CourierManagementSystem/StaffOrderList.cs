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
    public partial class StaffOrderList : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        private StaffHome Sth { get; set; }
        public StaffOrderList()
        {
            InitializeComponent();
            this.Dataac = new DataAccess();
            this.PopulateGridView();
        }
        public StaffOrderList(StaffHome sth):this()
        {
            this.Sth = sth;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Sth.Visible = true;
            this.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.query = @"select * from order2 where order_status = '" + this.cmbPosition.Text + "';";
            this.PopulateGridView(this.query);

        }
        private void PopulateGridView(string sql = "select * from order2;")
        {
            this.Datas = this.Dataac.ExecuteQuery(sql);

            this.dgvShowOrder.AutoGenerateColumns = false;
            this.dgvShowOrder.DataSource = this.Datas.Tables[0];
        }
    }
}
