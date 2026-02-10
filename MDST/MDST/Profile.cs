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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MDST
{
    public partial class Profile : UserControl
    {
        private string username;
        public Profile()
        {
            InitializeComponent();
        }

        public String ID { set { lblusername.Text = value; } }
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                lblusername.Text = username; // assuming lblusername is a Label
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            lblusername.Text = username;
        }

        private void lblusername_Enter(object sender, EventArgs e)
        {

        }

        private void Profile_Enter(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT userRole, name, dob, mobile, email, pass FROM userr WHERE username = '" + username + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cmbxuserroleedit.Text = reader["userRole"].ToString();
                        tbnameedit.Text = reader["name"].ToString();
                        tbdobedit.Text = reader["dob"].ToString();
                        tbmobnoedit.Text = reader["mobile"].ToString();
                        tbemailedit.Text = reader["email"].ToString();
                        tbpasswordedit.Text = reader["pass"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }

        private void btnresetprofile_Click(object sender, EventArgs e)
        {
          Profile_Enter(this, null);   
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;");

            string query = "UPDATE userr SET " +
                           "userRole = '" + cmbxuserroleedit.Text + "', " +
                           "name = '" + tbnameedit.Text + "', " +
                           "dob = '" + tbdobedit.Text + "', " +
                           "mobile = '" + tbmobnoedit.Text + "', " +
                           "email = '" + tbemailedit.Text + "', " +
                           "pass = '" + tbpasswordedit.Text + "' " +
                           "WHERE username = '" + lblusername.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully.");
                }
                else
                {
                    MessageBox.Show("No record was updated.");
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
    }
}
    

