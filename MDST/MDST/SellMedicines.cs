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
using System.Xml;

namespace MDST
{
    public partial class SellMedicines : UserControl
    {
        public SellMedicines()
        {
            InitializeComponent();
        }

        private void SellMedicines_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT mname FROM medic WHERE ISDATE(eDate) = 1 AND CONVERT(DATE, eDate, 120) > CAST(GETDATE() AS DATE) AND quantity > 0";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    SearchedMedicines.Items.Clear(); // Clear any previous items

                    while (reader.Read())
                    {
                        SearchedMedicines.Items.Add(reader["mname"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading medicines: " + ex.Message);
                }
            }
        }
        decimal totalBill = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbmidsell.Text))
            {
                MessageBox.Show("Please select a medicine.");
                return;
            }

            string mid = tbmidsell.Text;
            string mname = tbmnamesell.Text;

            // Validate units to sell
            if (!int.TryParse(tbunitssell.Text, out int unitsToSell) || unitsToSell <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Validate price per unit
            if (!decimal.TryParse(tbpricesell.Text, out decimal perUnit) || perUnit <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int availableQty = 0;
            string conStr = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                // Get available quantity
                string qtyQuery = $"SELECT quantity FROM medic WHERE mid = '{mid}'";
                SqlCommand cmd = new SqlCommand(qtyQuery, con);
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out availableQty))
                {
                    if (unitsToSell > availableQty)
                    {
                        MessageBox.Show($"Out of stock! Only {availableQty} units available.");
                        return;
                    }

                    // Update quantity in DB
                    string updateQuery = $"UPDATE medic SET quantity = quantity - {unitsToSell} WHERE mid = '{mid}'";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Medicine not found in database.");
                    return;
                }
            }

            // Calculate bill
            decimal total = perUnit * unitsToSell;
            totalBill += total;

            // Initialize columns if first time
            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.Columns.Add("mid", "Medicine ID");
                dataGridView1.Columns.Add("mname", "Medicine Name");
                dataGridView1.Columns.Add("quantity", "Quantity");
                dataGridView1.Columns.Add("price", "Price/Unit");
                dataGridView1.Columns.Add("total", "Total");
            }

            // Add row to DataGridView
            dataGridView1.Rows.Add(mid, mname, unitsToSell, perUnit, total);

            // Update bill label
            lblbill.Text = $"Total Bill: {totalBill}";

            // Clear fields
            tbmidsell.Clear();
            tbmnamesell.Clear();
            tbunitssell.Clear();
            tbpricesell.Clear();
            tbexpiresell.Clear();
            SearchedMedicines.ClearSelected();

            // Reload listbox if needed
            SellMedicines_Load(this, null);
        }

        private void tbsearchsell_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbsearchsell.Text.Trim();
            string connectionString = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";

            // LIKE query with wildcard %
            string query = "SELECT mname FROM medic WHERE ISDATE(eDate) = 1 AND CONVERT(DATE, eDate, 120) > CAST(GETDATE() AS DATE) AND quantity > 0 AND mname LIKE '%" + searchText + "%'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    SearchedMedicines.Items.Clear();

                    while (reader.Read())
                    {
                        SearchedMedicines.Items.Add(reader["mname"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching medicines: " + ex.Message);
                }
            }

        }

        private void SearchedMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbunitssell.Clear();

            // Get selected medicine name
            string name = SearchedMedicines.GetItemText(SearchedMedicines.SelectedItem);
            tbmnamesell.Text = name;

            // Database query
            string connectionString = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            string query = "SELECT mid, eDate, perUnit FROM medic WHERE mname = '" + name + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tbmidsell.Text = reader["mid"].ToString();
                        tbexpiresell.Text = reader["eDate"].ToString();
                        tbpricesell.Text = reader["perUnit"].ToString();
                    }

                    reader.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving medicine info: " + ex.Message);
                }
            }

        }

        private void tbunitssell_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbunitssell.Text, out int quantity) &&
                int.TryParse(tbpricesell.Text, out int unitPrice))
            {
                int total = quantity * unitPrice;
                tbtotalsell.Text = total.ToString();
            }
            else
            {
                tbtotalsell.Clear();
            }
        }
    }
}
