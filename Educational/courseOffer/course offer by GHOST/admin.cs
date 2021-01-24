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
    public partial class admin : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        string connectionstring = @"Data Source=MARZUK_PC\SQLEXPRESS;Initial Catalog=crsofr;Integrated Security=True;";

        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                update up = new update();
                up.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                index i = new index();
                i.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter(@"select Course_Code,Course_Title,Credit_Hour from Courses", connectionstring);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                insert inst = new insert();
                inst.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete dlt = new delete();
            dlt.Show();
        }

    }
}
