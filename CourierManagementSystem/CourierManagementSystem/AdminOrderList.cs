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
    public partial class AdminOrderList : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        private AdminHome Adm { get; set; }
        public AdminOrderList()
        {
            InitializeComponent();
            this.Dataac = new DataAccess();
            this.PopulateGridView();
        }

        public AdminOrderList(AdminHome adm): this()
        {
            this.Adm = adm;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Adm.Visible = true;
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
