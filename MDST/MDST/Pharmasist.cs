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
    public partial class Pharmasist : Form
    { 
        public Pharmasist()
        {
            InitializeComponent();
        }

        private void btnlogoutp_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
            this.Hide();
        }

        private void btndashboardp_Click(object sender, EventArgs e)
        {
            pDashboard1.Visible = true;
            pDashboard1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            btndashboardp.PerformClick();
        }

        private void btnaddmedicinep_Click(object sender, EventArgs e)
        {
            pAddMedicine1.Visible = true;
            pAddMedicine1.BringToFront();
        }

        private void Pharmasist_Load(object sender, EventArgs e)
        {
            pAddMedicine1.Visible = false;
            viewMedicinesp1.Visible = false;
            modifyMedicinep1.Visible = false;
            validityCheck1.Visible = false;
            sellMedicines1.Visible = false;
            
        }

        private void pAddMedicine1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnviewmedicinep_Click(object sender, EventArgs e)
        {
            viewMedicinesp1.Visible = true;
            viewMedicinesp1.BringToFront();
        }

        private void btnmodifymedicinep_Click(object sender, EventArgs e)
        {
            modifyMedicinep1.Visible = true;
            modifyMedicinep1.BringToFront();
        }

        private void btnvalidityp_Click(object sender, EventArgs e)
        {
            validityCheck1.Visible = true;
            validityCheck1.BringToFront();
        }

        private void btnsellmedicinep_Click(object sender, EventArgs e)
        {
            sellMedicines1.Visible = true;
            sellMedicines1.BringToFront();
        }
    }
}
