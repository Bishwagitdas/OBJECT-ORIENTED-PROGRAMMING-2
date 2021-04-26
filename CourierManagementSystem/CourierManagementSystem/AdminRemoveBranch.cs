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
    public partial class AdminRemoveBranch : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        private AdminHome Adm { get; set; }
        public AdminRemoveBranch()
        {
            InitializeComponent();
            this.Dataac = new DataAccess();
            this.PopulateGridView();
        }
        public AdminRemoveBranch(AdminHome adm):this()
        {
            this.Adm = adm;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Adm.Visible = true;
            this.Visible = false;
        }

        private void btnRemoveBranch_Click(object sender, EventArgs e)
        {
            try
            {
                var branch_id = this.dgvStaffSearch.CurrentRow.Cells["brach_id"].Value.ToString();
                var branch_name = this.dgvStaffSearch.CurrentRow.Cells["branch_name"].Value.ToString();

                this.query = "delete from branch where brach_id = '" + branch_id + "';";
                int count = this.Dataac.ExecuteUpdateQuery(this.query);


                this.PopulateGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        private void PopulateGridView(string sql = "select * from branch;")
        {
            this.Datas = this.Dataac.ExecuteQuery(sql);

            this.dgvStaffSearch.AutoGenerateColumns = false;
            this.dgvStaffSearch.DataSource = this.Datas.Tables[0];
        }
    }
}
