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
    public partial class AdminStaffDelete : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        private AdminHome Adm { get; set; }
        public AdminStaffDelete()
        {
            InitializeComponent();
            this.Dataac = new DataAccess();
            this.PopulateGridView();
        }
        public AdminStaffDelete(AdminHome adm):this()
        {
            this.Adm = adm;
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Adm.Visible = true;
            this.Visible = false;
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var staff_id = this.dgvStaffSearch.CurrentRow.Cells["staff_id"].Value.ToString();
                var staff_name = this.dgvStaffSearch.CurrentRow.Cells["staff_name"].Value.ToString();

                this.query = "delete from staff where staff_id = '" + staff_id + "';";
                int count = this.Dataac.ExecuteUpdateQuery(this.query);

                this.PopulateGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        private void PopulateGridView(string sql = "select * from staff;")
        {
            this.Datas = this.Dataac.ExecuteQuery(sql);

            this.dgvStaffSearch.AutoGenerateColumns = false;
            this.dgvStaffSearch.DataSource = this.Datas.Tables[0];
        }
    }
}
