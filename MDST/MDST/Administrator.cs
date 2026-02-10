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
    public partial class Administrator : Form
    {
        String user = "";
        public Administrator(String username)
        {
            InitializeComponent();
            user = username;
            viewUsers1.ID = ID;
            profile1.ID = ID;
            profile1.Username = user;
        }


        public Administrator()
        {
            InitializeComponent();
        }

        public String ID { get { return user; } }


        private void button3_Click(object sender, EventArgs e)
        {
            viewUsers1.Visible = true;
            viewUsers1.BringToFront();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            dashboard1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            dashboard1.Visible=false;
            addUser1.Visible=false;
            viewUsers1.Visible=false;
            profile1.Visible=false;

            profile1.Username = user;
            viewUsers1.ID = user;
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            addUser1.Visible = true;
            addUser1.BringToFront();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            profile1.Visible = true;
            profile1.BringToFront();
        }
    }
}
