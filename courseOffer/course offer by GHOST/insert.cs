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
    public partial class insert : Form
    {
        string connectionstring = @"Data Source=MARZUK_PC\SQLEXPRESS;Initial Catalog=crsofr;Integrated Security=True;";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;


        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {
            
        }
        void clear()
        {
            icc.Text = ict.Text = ich.Text = "";
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

        private void iinsert_Click(object sender, EventArgs e)
        {
            if (icc.Text == "" || ict.Text == "" || ich.Text == "")
            {
                MessageBox.Show("Please fill the Fields !!!");
            }
            try
            {

                con = new SqlConnection(connectionstring);
                con.Open();
                cmd = new SqlCommand("courseadd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Course_Code", icc.Text);
                cmd.Parameters.Add("@Course_Title", ict.Text);
                cmd.Parameters.Add("@Credit_Hour", ich.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is inserted !!!");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ict_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
