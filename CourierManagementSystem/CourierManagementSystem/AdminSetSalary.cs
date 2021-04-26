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
    public partial class AdminSetSalary : Form
    {
        internal DataAccess Dataac { get; set; }
        internal DataSet Datas { get; set; }
        internal String query { get; set; }
        private AdminHome Adm { get; set; }
        public AdminSetSalary()
        {
            InitializeComponent();
        }
        public AdminSetSalary(AdminHome adm):this()
        {
            this.Adm = adm;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Adm.Visible = true;
            this.Visible = false;
        }

        private void btnSetSalary_Click(object sender, EventArgs e)
        {


            this.query = @"insert into salary values ('" + this.txtSalaryId.Text + "','" + this.txtSalary.Text + "','" + this.txtBonus.Text + "','" + this.txtStaffId.Text + "');";
            int count = this.Dataac.ExecuteUpdateQuery(this.query);

            if (count == 1)
                MessageBox.Show("Data inserted successfully");
            else
                MessageBox.Show("Error while inserting data");


        }
        private void PopulateGridView(string sql = "select * from salary;")
        {
            this.Datas = this.Dataac.ExecuteQuery(sql);

            this.dgvStaffSearch.AutoGenerateColumns = false;
            this.dgvStaffSearch.DataSource = this.Datas.Tables[0];
        }
    }
}
