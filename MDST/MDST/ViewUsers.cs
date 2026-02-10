using System;
using System.Data.SqlClient;
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
    public partial class ViewUsers : UserControl
    {
        String currentuser = "";
        public String ID
        {
            set { currentuser=value; }
        }
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            try
            {
                
                string conStr = "Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=SSPI;TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(conStr);
                string query = "SELECT id, userRole, name, username, dob, mobile, email FROM userr";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void tbsearchusername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string conStr = "Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=SSPI;TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string searchText = tbsearchusername.Text.Trim();
                string query = "SELECT id, userRole, name, username, dob, mobile, email FROM userr WHERE username LIKE '%" + searchText + "%'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    string selectedUsername = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                    //  deletion of loggedin user
                    if (selectedUsername == currentuser)
                    {
                        MessageBox.Show("You cannot delete the currently logged-in user!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string conStr = "Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=SSPI;TrustServerCertificate=True;";
                        SqlConnection conn = new SqlConnection(conStr);
                        conn.Open();

                      
                        string query = "DELETE FROM userr WHERE username = '" + selectedUsername + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                       
                        tbsearchusername_TextChanged(null, null); // reloads data

                        MessageBox.Show("User deleted successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            ViewUsers_Load(this, null);
        }
    }
}
