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

namespace course_offer_by_GHOST
{
    public partial class delete : Form
    {
        string connectionstring = @"Data Source=MARZUK_PC\SQLEXPRESS;Initial Catalog=crsofr;Integrated Security=True;";
        
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "delete from Courses where Course_Code = '" + dcc.Text + "';";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            if (dcc.Text == "")
            {
                MessageBox.Show("Please fill the fields !!!");
            }
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                MessageBox.Show("Deleted !!!");
                clear();
                while (rdr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clear()
        {
            dcc.Text = "";
        }

        private void dback_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                admin ad = new admin();
                ad.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
