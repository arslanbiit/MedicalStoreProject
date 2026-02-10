using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDST
{
    public partial class PAddMedicine : UserControl
    {
        public PAddMedicine()
        {
            InitializeComponent();
        }

        private void PAddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbmquantityp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpricep_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnaddmedicine_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";

            string mid = tbmidp.Text;
            string mname = tbmnamep.Text;
            string mnumber = tbmnumberp.Text;
            string mDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string eDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string quantity = tbmquantityp.Text;
            string perUnit = tbpricep.Text;

            string query = "INSERT INTO medic (mid, mname, mnumber, mDate, eDate, quantity, perUnit) VALUES (" +
                           "'" + mid + "', " +
                           "'" + mname + "', " +
                           "'" + mnumber + "', " +
                           "'" + mDate + "', " +
                           "'" + eDate + "', " +
                           "" + quantity + ", " +
                           "" + perUnit + ")";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Medicine added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add medicine.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnresetmp_Click(object sender, EventArgs e)
        {
            tbmidp.Clear();
            tbmnamep.Clear();
            tbmnumberp.Clear();
            tbmquantityp.Clear();
            tbpricep.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
