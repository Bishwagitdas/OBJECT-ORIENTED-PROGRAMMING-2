using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace CourierManagementSystem
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon { get; set; }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom { get; set; }

        private SqlDataAdapter sqlda;
        public SqlDataAdapter Sqlda { get; set; }

        private DataSet datas;
        public DataSet Datas { get; set; }

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-AB89EBN\SQLEXPRESS;Initial Catalog=couriermanagement;User ID=sa;Password=Ayonroy@155");
            this.Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sqlda = new SqlDataAdapter(this.Sqlcom);
                this.Datas = new DataSet();
                this.Sqlda.Fill(this.Datas);
                return this.Datas;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            this.ExecuteQuery(sql);
            if (this.Datas != null)
                return this.Datas.Tables[0];
            else
                return null;
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
