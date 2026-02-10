namespace MDST
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.btnviewuser = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profile1 = new MDST.Profile();
            this.viewUsers1 = new MDST.ViewUsers();
            this.addUser1 = new MDST.AddUser();
            this.dashboard1 = new MDST.Dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.btnviewuser);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 455);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.Location = new System.Drawing.Point(30, 401);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(172, 35);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.Location = new System.Drawing.Point(30, 340);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(172, 37);
            this.btnprofile.TabIndex = 4;
            this.btnprofile.Text = "Profile";
            this.btnprofile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnprofile.UseVisualStyleBackColor = false;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnviewuser
            // 
            this.btnviewuser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnviewuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnviewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewuser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnviewuser.Image = ((System.Drawing.Image)(resources.GetObject("btnviewuser.Image")));
            this.btnviewuser.Location = new System.Drawing.Point(30, 284);
            this.btnviewuser.Name = "btnviewuser";
            this.btnviewuser.Size = new System.Drawing.Size(172, 37);
            this.btnviewuser.TabIndex = 3;
            this.btnviewuser.Text = "View Users";
            this.btnviewuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnviewuser.UseVisualStyleBackColor = false;
            this.btnviewuser.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadduser.Image = ((System.Drawing.Image)(resources.GetObject("btnadduser.Image")));
            this.btnadduser.Location = new System.Drawing.Point(30, 227);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(172, 38);
            this.btnadduser.TabIndex = 2;
            this.btnadduser.Text = "Add User";
            this.btnadduser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndashboard.Location = new System.Drawing.Point(30, 159);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(172, 47);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.profile1);
            this.panel2.Controls.Add(this.viewUsers1);
            this.panel2.Controls.Add(this.addUser1);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Location = new System.Drawing.Point(232, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 455);
            this.panel2.TabIndex = 1;
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(-3, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(569, 451);
            this.profile1.TabIndex = 3;
            this.profile1.Username = null;
            // 
            // viewUsers1
            // 
            this.viewUsers1.Location = new System.Drawing.Point(-3, 2);
            this.viewUsers1.Name = "viewUsers1";
            this.viewUsers1.Size = new System.Drawing.Size(572, 450);
            this.viewUsers1.TabIndex = 2;
            // 
            // addUser1
            // 
            this.addUser1.Location = new System.Drawing.Point(0, 1);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(569, 455);
            this.addUser1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(1, 1);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(569, 455);
            this.dashboard1.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnprofile;
        private System.Windows.Forms.Button btnviewuser;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel2;
        private Dashboard dashboard1;
        private AddUser addUser1;
        private ViewUsers viewUsers1;
        private Profile profile1;
    }
}