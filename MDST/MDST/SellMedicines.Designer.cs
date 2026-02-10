namespace MDST
{
    partial class SellMedicines
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellMedicines));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsearchsell = new System.Windows.Forms.TextBox();
            this.SearchedMedicines = new System.Windows.Forms.ListBox();
            this.tbmidsell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmnamesell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbexpiresell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpricesell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbunitssell = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbtotalsell = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblbill = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sell Medicines";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // tbsearchsell
            // 
            this.tbsearchsell.Location = new System.Drawing.Point(7, 93);
            this.tbsearchsell.Name = "tbsearchsell";
            this.tbsearchsell.Size = new System.Drawing.Size(162, 20);
            this.tbsearchsell.TabIndex = 3;
            this.tbsearchsell.TextChanged += new System.EventHandler(this.tbsearchsell_TextChanged);
            // 
            // SearchedMedicines
            // 
            this.SearchedMedicines.FormattingEnabled = true;
            this.SearchedMedicines.Location = new System.Drawing.Point(7, 132);
            this.SearchedMedicines.Name = "SearchedMedicines";
            this.SearchedMedicines.Size = new System.Drawing.Size(162, 381);
            this.SearchedMedicines.TabIndex = 4;
            this.SearchedMedicines.SelectedIndexChanged += new System.EventHandler(this.SearchedMedicines_SelectedIndexChanged);
            // 
            // tbmidsell
            // 
            this.tbmidsell.Enabled = false;
            this.tbmidsell.Location = new System.Drawing.Point(195, 93);
            this.tbmidsell.Name = "tbmidsell";
            this.tbmidsell.Size = new System.Drawing.Size(162, 20);
            this.tbmidsell.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicine ID";
            // 
            // tbmnamesell
            // 
            this.tbmnamesell.Enabled = false;
            this.tbmnamesell.Location = new System.Drawing.Point(195, 160);
            this.tbmnamesell.Name = "tbmnamesell";
            this.tbmnamesell.Size = new System.Drawing.Size(162, 20);
            this.tbmnamesell.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medicine Name";
            // 
            // tbexpiresell
            // 
            this.tbexpiresell.Enabled = false;
            this.tbexpiresell.Location = new System.Drawing.Point(195, 242);
            this.tbexpiresell.Name = "tbexpiresell";
            this.tbexpiresell.Size = new System.Drawing.Size(162, 20);
            this.tbexpiresell.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Expire Date";
            // 
            // tbpricesell
            // 
            this.tbpricesell.Enabled = false;
            this.tbpricesell.Location = new System.Drawing.Point(402, 93);
            this.tbpricesell.Name = "tbpricesell";
            this.tbpricesell.Size = new System.Drawing.Size(162, 20);
            this.tbpricesell.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price Per Unit";
            // 
            // tbunitssell
            // 
            this.tbunitssell.Location = new System.Drawing.Point(402, 160);
            this.tbunitssell.Name = "tbunitssell";
            this.tbunitssell.Size = new System.Drawing.Size(162, 20);
            this.tbunitssell.TabIndex = 14;
            this.tbunitssell.TextChanged += new System.EventHandler(this.tbunitssell_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "No Of Units";
            // 
            // tbtotalsell
            // 
            this.tbtotalsell.Enabled = false;
            this.tbtotalsell.Location = new System.Drawing.Point(402, 242);
            this.tbtotalsell.Name = "tbtotalsell";
            this.tbtotalsell.Size = new System.Drawing.Size(162, 20);
            this.tbtotalsell.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Price";
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnaddtocart.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtocart.Image")));
            this.btnaddtocart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddtocart.Location = new System.Drawing.Point(434, 269);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(130, 34);
            this.btnaddtocart.TabIndex = 17;
            this.btnaddtocart.Text = "Add to Cart";
            this.btnaddtocart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddtocart.UseVisualStyleBackColor = false;
            this.btnaddtocart.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(175, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 187);
            this.dataGridView1.TabIndex = 18;
            // 
            // lblbill
            // 
            this.lblbill.AutoSize = true;
            this.lblbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.Location = new System.Drawing.Point(333, 514);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(44, 16);
            this.lblbill.TabIndex = 21;
            this.lblbill.Text = "Rs 0.0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No of Units";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Unit";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // SellMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblbill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnaddtocart);
            this.Controls.Add(this.tbtotalsell);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbunitssell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbpricesell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbexpiresell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbmnamesell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbmidsell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchedMedicines);
            this.Controls.Add(this.tbsearchsell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "SellMedicines";
            this.Size = new System.Drawing.Size(577, 548);
            this.Load += new System.EventHandler(this.SellMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsearchsell;
        private System.Windows.Forms.ListBox SearchedMedicines;
        private System.Windows.Forms.TextBox tbmidsell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmnamesell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbexpiresell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbpricesell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbunitssell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbtotalsell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
