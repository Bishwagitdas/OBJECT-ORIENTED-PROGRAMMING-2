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
    public partial class StaffReleaseOrder : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        
        private StaffHome Sth { get; set; }
        public StaffReleaseOrder()
        {
            InitializeComponent();
            this.Dataac = new DataAccess();
            this.PopulateGridView();
        }
        public StaffReleaseOrder(StaffHome sth):this()
        {
            this.Sth = sth;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Sth.Visible = true;
            this.Visible = false;
        }

        private void btnReleaseOrder_Click(object sender, EventArgs e)
        {
            var Order_id = this.dgvReleaseOrder.CurrentRow.Cells["order_id"].Value.ToString();
            this.query = @"UPDATE order2 SET order_status= 'Release' WHERE order_id= '"+ Order_id +"';";
            int count = this.Dataac.ExecuteUpdateQuery(this.query);


            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from order2;")
        {
            this.Datas = this.Dataac.ExecuteQuery(sql);

            this.dgvReleaseOrder.AutoGenerateColumns = false;
            this.dgvReleaseOrder.DataSource = this.Datas.Tables[0];
        }
    }
}
