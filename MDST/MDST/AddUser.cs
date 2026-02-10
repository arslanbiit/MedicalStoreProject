using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDST
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            try
            {
               
                string role = cmbxuserrole.SelectedItem.ToString();
                string name = tbname.Text;
                string dob = dateTimePicker1.Text;
                Int64 mob = Int64.Parse(tbmobileno.Text);
                string email = tbemail.Text;
                string uname = tbusername.Text;
                string pass = tbpassword.Text;

             
                string con = "Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=SSPI;TrustServerCertificate=True;";
                SqlConnection conn = new SqlConnection(con);

                
                string query = "INSERT INTO userr (userRole, name, dob, mobile, email, username, pass) " +
                               "VALUES ('" + role + "', '" + name + "', '" + dob + "', " + mob + ", '" + email + "', '" + uname + "', '" + pass + "')";

                
                SqlCommand cmd = new SqlCommand(query, conn);

                
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();

                MessageBox.Show("User registered successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username Already Exist!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnadduserreset_Click(object sender, EventArgs e)
        {
            tbemail.Clear();
            tbname.Clear();
            tbmobileno.Clear();
            tbusername.Clear();
            tbpassword.Clear();
            dateTimePicker1.ResetText();
            cmbxuserrole.SelectedIndex = -1;
        }
    }
}
