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
    public partial class update : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        string connectionstring = @"Data Source=MARZUK_PC\SQLEXPRESS;Initial Catalog=crsofr;Integrated Security=True;";
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
                MessageBox.Show("Data Updated !!! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"select Course_Code,Course_Title,Credit_Hour from Courses", connectionstring);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
