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
    public partial class index : Form
    {
        string connectionstring = @"Data Source=MARZUK_PC\SQLEXPRESS;Initial Catalog=crsofr;Integrated Security=True;";

        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void lpasswordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = "Admin";
                int pass = 12345;

                if (user == this.lusertxt.Text && pass == Convert.ToInt32(this.lpasswordtxt.Text))
                {
                    this.Hide();
                    admin ad = new admin();
                    ad.Show();
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Registration where User_Id = '" + lusertxt.Text + "' and Password ='" + lpasswordtxt.Text + "' ",connectionstring);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        students ad = new students();
                        ad.Show();
                    }
                    else
                        MessageBox.Show("Please check your user name or password !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (suserid.Text == "" || spass.Text == "" || srepass.Text == "")
            {
                MessageBox.Show("Please fill up the mandetory fields !!! ");
            }
            else if (spass.Text != srepass.Text)
            {
                MessageBox.Show("Password do not match !!! ");
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@First_Name", sfname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Last_Name", slname.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@User_Id", suserid.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", spass.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Repassword", srepass.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Complete !!! ");
                    clear();
                }
            }
        }
        void clear()
        {
            sfname.Text = slname.Text  = suserid.Text = spass.Text = srepass.Text = "";
        }
    }
}
