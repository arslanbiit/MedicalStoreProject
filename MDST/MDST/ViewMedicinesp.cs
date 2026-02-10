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
    public partial class ViewMedicinesp : UserControl
    {
        public ViewMedicinesp()
        {
            InitializeComponent();
        }

        private void ViewMedicinesp_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connection);

            try
            {
                con.Open();
                string query = "SELECT * FROM medic";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void tbsearchusername_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbsearchusername.Text.Trim();
            string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM medic WHERE mname LIKE '%" + searchText + "%'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
  
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            
                DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
                    string query = "DELETE FROM medic WHERE id = " + selectedId;

                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Medicine deleted successfully.");

                         
                            LoadMedicines();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while deleting: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void LoadMedicines()
        {
            string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT * FROM medic";

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
