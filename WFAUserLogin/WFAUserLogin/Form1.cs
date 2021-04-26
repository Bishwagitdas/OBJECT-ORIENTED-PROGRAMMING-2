using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WFAUserLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-FP46ITQ;Initial Catalog=userlogindb;User ID=sa;Password=18367301");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from userlogin;",sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            this.label1.Text = ds.Tables[0].Rows[0][0].ToString();
            this.label2.Text = ds.Tables[0].Rows[0][2].ToString();
            sqlcon.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-FP46ITQ;Initial Catalog=userlogindb;User ID=sa;Password=18367301");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from userlogin where id = '"+this.textBox1.Text+ "' and password = '" + this.textBox2.Text + "';", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if(ds.Tables[0].Rows.Count==1)
                MessageBox.Show("Login valid");

            //int count=0;
            //while(count<ds.Tables[0].Rows.Count)
           // {
                //if (this.textBox1.Text == ds.Tables[0].Rows[count][0].ToString() && this.textBox1.Text == ds.Tables[0].Rows[count][2].ToString())
                   // MessageBox.Show("Login valid");
                //else
                //    MessageBox.Show("Login invalid");

               // count++;
           // }


            sqlcon.Close();
        }
    }
}
