using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CourierManagementSystem
{
    public partial class AdminStaffSearch : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        private AdminHome Adm { get; set; }
        public AdminStaffSearch()
        {
            InitializeComponent();
            this.Dataac = new DataAccess();
            this.PopulateGridView();
        }
        public AdminStaffSearch(AdminHome adm):this()
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
            this.query = @"select * from staff where branch_id = '" + this.cmbPosition.Text + "';";
            this.PopulateGridView(this.query);
        }

        private void PopulateGridView(string sql = "select * from staff;")
        {
            this.Datas = this.Dataac.ExecuteQuery(sql);

            this.dgvStaffSearch.AutoGenerateColumns = false;
            this.dgvStaffSearch.DataSource = this.Datas.Tables[0];
        }
    }
}
