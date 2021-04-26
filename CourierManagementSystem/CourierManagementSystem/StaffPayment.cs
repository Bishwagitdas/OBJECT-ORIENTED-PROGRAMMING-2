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
    public partial class StaffPayment : Form
    {
        private StaffHome Sth { get; set; }
        public StaffPayment()
        {
            InitializeComponent();
        }
        public StaffPayment(StaffHome sth):this()
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
            DataAccess dataccess = new DataAccess();
            String query = @"select order_cus_name, order_date, order_amount from order2 where order_id = '" + this.txtOrderId.Text + "';"; 
            DataSet datase = dataccess.ExecuteQuery(query);

            this.lblOutCustomerName.Text = datase.Tables[0].Rows[0][0].ToString();
            this.lblOutDate.Text = datase.Tables[0].Rows[0][1].ToString();
            this.lblTotalAmout.Text = datase.Tables[0].Rows[0][2].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess dataccess1 = new DataAccess();
            String query1 = @"select payment_status from payment where order_id = '" + this.txtPayOrderId.Text + "';";
            DataSet datase1 = dataccess1.ExecuteQuery(query1);

            this.lblOutPorderStatus.Text = datase1.Tables[0].Rows[0][0].ToString();
        }
    }
}
