using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDST
{
    public partial class ModifyMedicinep : UserControl
    {
        public ModifyMedicinep()
        {
            InitializeComponent();
        }

        private void ModifyMedicinep_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT * FROM medic WHERE mid = '" + tbmidm.Text + "'";

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tbmnamem.Text = reader["mname"].ToString();
                        tbmnumberm.Text = reader["mnumber"].ToString();
                        tbbuilddate.Text = reader["mDate"].ToString();
                        tbexpirydate.Text = reader["eDate"].ToString();
                        tbmquantitym.Text = reader["quantity"].ToString();
                        tbpricem.Text = reader["perUnit"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No medicine found with this ID.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnupdatemedicine_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";

            string mid = tbmidm.Text; 
            string mname = tbmnamem.Text;
            string mnumber = tbmnumberm.Text;
            string mDate = tbbuilddate.Text;
            string eDate = tbexpirydate.Text;
            string quantity = tbmquantitym.Text;
            string perUnit = tbpricem.Text;
            int newq=int.Parse(tbmquantitym.Text)+int.Parse(tbaddquantity.Text);

            string query = "UPDATE medic SET " +
                           "mname = '" + mname + "', " +
                           "mnumber = '" + mnumber + "', " +
                           "mDate = '" + mDate + "', " +
                           "eDate = '" + eDate + "', " +
                           "quantity = " + newq + ", " +
                           "perUnit = " + perUnit +
                           " WHERE mid = '" + mid + "'";

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medicine record updated successfully.");
                        
                    }
                    else
                    {
                        MessageBox.Show("No record found to update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnresetmedicines_Click(object sender, EventArgs e)
        {
            tbmidm.Clear();
            tbmnamem.Clear();
            tbmnumberm.Clear();
            tbmquantitym.Clear();
            tbpricem.Clear();
            tbbuilddate.Clear();
            tbexpirydate.Clear();

        }
    }
}
