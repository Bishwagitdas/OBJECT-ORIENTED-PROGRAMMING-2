using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMovieList
{
    public partial class FormMovie : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        
        public FormMovie()
        {
            InitializeComponent();
            this. Da = new DataAccess();

            //string sql = "select * from moviedetails;";
            this.PopulateGrideView();
            
        }
    

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
           
            this.PopulateGrideView();
        }
        private void PopulateGrideView(string sql= "select * from moviedetails")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvMovieDetails.AutoGenerateColumns = false;
            this.dgvMovieDetails.DataSource = this.Ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from moviedetails where genre = '"+this.txtSearch.Text+"';";
            this.PopulateGrideView(this.Sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from moviedetails where title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGrideView(this.Sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "insert into moviedetails values('" + this.txtMovieId.Text + "', '" + this.txtTitle.Text + "', " + this.txtImdb.Text + ", " + this.txtBoxOffice.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "'); ";
                int row = this.Da.ExecuteUpdateQuery(this.Sql);
                if (row == 1)
                    MessageBox.Show("Data inserted successfully in database");
                else
                    MessageBox.Show("error Data insertion failed");

                this.PopulateGrideView();


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error:" + exc.Message);

            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvMovieDetails.CurrentRow.Cells["id"].Value.ToString();
                string name = this.dgvMovieDetails.CurrentRow.Cells["title"].Value.ToString();
                this.Sql = "delete from moviedetails where id ='" + id + "';";

                int row = this.Da.ExecuteUpdateQuery(this.Sql);
                if (row == 1)
                    MessageBox.Show(name  + " has been deleted from database");
                else
                    MessageBox.Show("error Data deletion failed");

                this.PopulateGrideView();


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error:" + exc.Message);

            }
            

        }
    }
}
