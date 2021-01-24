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
    public partial class students : Form
    {
        string connectionstring = @"Data Source=MARZUK_PC\SQLEXPRESS;Initial Catalog=crsofr;Integrated Security=True;";
        public students()
        {
            InitializeComponent();
        }

        private void students_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            index i = new index();
            i.Show();
        }

        private void see_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection sqlcon = new SqlConnection(connectionstring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter("select *from Courses", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
