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
using System.Windows.Forms.DataVisualization.Charting;

namespace MDST
{
    public partial class PDashboard : UserControl
    {
        public PDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PDashboard_Load(object sender, EventArgs e)
        {
            btnreload.PerformClick();
        }

        private void btnreload_Click(object sender, EventArgs e)
        { 
            string connection = @"Data Source=localhost;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string qValid = "SELECT COUNT(mname) FROM medic WHERE CAST(eDate AS DATE) >= CAST(GETDATE() AS DATE)";
            SqlCommand cmdValid = new SqlCommand(qValid, con);
            int validCount = (int)cmdValid.ExecuteScalar();
            string qExpired = "SELECT COUNT(mname) FROM medic WHERE CAST(eDate AS DATE) < CAST(GETDATE() AS DATE)";
            SqlCommand cmdExpired = new SqlCommand(qExpired, con);
            int expiredCount = (int)cmdExpired.ExecuteScalar();
            con.Close();
            chart1.Series.Clear(); 
            chart1.Titles.Clear();
            chart1.Titles.Add("Medicine Expiry Status");
            Series series = new Series("Medicines");
            series.ChartType = SeriesChartType.Bar; 
            series.Points.AddXY("Valid", validCount);
            series.Points.AddXY("Expired", expiredCount);            
            series.Color = System.Drawing.Color.DodgerBlue;
            series["PointWidth"] = "0.6";
            chart1.Series.Add(series);
            chart1.Legends[0].Enabled = true;
        }
    }
}
