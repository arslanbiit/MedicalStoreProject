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
    public partial class ValidityCheck : UserControl
    {
        public ValidityCheck()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            string query = "";

            if (selected == "Show All Medicines")
            {
                query = "SELECT * FROM medic";
                checklabel.Text = "All Medicines";
            }
            else if (selected == "Expired Medicines")
            {
  
                query = @"
            SELECT * FROM medic 
            WHERE ISDATE(eDate) = 1 
              AND CONVERT(DATE, eDate, 120) < CAST(GETDATE() AS DATE)";
                checklabel.Text = "Expired Medicines";
            }
            else if (selected == "Valid Medicines")
            {
                query = @"
            SELECT * FROM medic 
            WHERE ISDATE(eDate) = 1 
              AND CONVERT(DATE, eDate, 120) >= CAST(GETDATE() AS DATE)";
                checklabel.Text = "Valid Medicines";
            }

            string connectionString = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

    }
}
