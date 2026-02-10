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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbusername.Clear();
            tbpassword.Clear();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = tbusername.Text.Trim();
                string pass = tbpassword.Text.Trim();

                string con = "Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=SSPI;TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(con);
                conn.Open();

                
                string Query = "SELECT COUNT(*) FROM userr";
                SqlCommand Cmd = new SqlCommand(Query, conn);
                int count = (int)Cmd.ExecuteScalar();

                if (count == 0)
                {
                   
                    if (uname == "root" && pass == "root")
                    {
                      
                        Administrator adminForm = new Administrator(tbusername.Text);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                   
                    string loginQuery = "SELECT userRole FROM userr WHERE username = '" + uname + "' AND pass = '" + pass + "'";
                    SqlCommand loginCmd = new SqlCommand(loginQuery, conn);
                    SqlDataReader reader = loginCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["userRole"].ToString();

                        if (role == "Administrator")
                        {
                            Administrator adminForm = new Administrator(tbusername.Text);
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (role == "Pharmasist")
                        {
                            Pharmasist pharmasist = new Pharmasist(); 
                            pharmasist.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbpassword.PasswordChar == '\0')
            {
                tbpassword.PasswordChar = '●';  
            }
            else
            {
                tbpassword.PasswordChar = '\0';
            }

        }
    }
}
