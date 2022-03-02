namespace carrental
{
    partial class rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rental));
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.txtdue = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.txtcarid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtid1
            // 
            this.txtid1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid1.Location = new System.Drawing.Point(269, 318);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(535, 32);
            this.txtid1.TabIndex = 11;
            // 
            // txtdue
            // 
            this.txtdue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdue.Location = new System.Drawing.Point(257, 780);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(271, 32);
            this.txtdue.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rent ID";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(249, 706);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(319, 32);
            this.txtdate.TabIndex = 10;
            // 
            // txtfee
            // 
            this.txtfee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfee.Location = new System.Drawing.Point(280, 626);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(328, 32);
            this.txtfee.TabIndex = 9;
            this.txtfee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfee_KeyPress);
            // 
            // txtcustname
            // 
            this.txtcustname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(318, 549);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(329, 32);
            this.txtcustname.TabIndex = 8;
            this.txtcustname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustname_KeyPress);
            // 
            // txtcustid
            // 
            this.txtcustid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustid.Location = new System.Drawing.Point(330, 472);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(353, 32);
            this.txtcustid.TabIndex = 7;
            this.txtcustid.TextChanged += new System.EventHandler(this.txtcustid_TextChanged);
            this.txtcustid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustid_KeyPress);
            // 
            // txtcarid
            // 
            this.txtcarid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcarid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarid.FormattingEnabled = true;
            this.txtcarid.Location = new System.Drawing.Point(298, 395);
            this.txtcarid.Name = "txtcarid";
            this.txtcarid.Size = new System.Drawing.Size(429, 32);
            this.txtcarid.TabIndex = 6;
            this.txtcarid.SelectedIndexChanged += new System.EventHandler(this.txtcarid_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 778);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 701);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rental Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rental ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Available :-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(200, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 42);
            this.label9.TabIndex = 7;
            this.label9.Text = "----";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(82, 935);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 74);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(1017, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(941, 487);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CarID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CustomerID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CustomerName";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rental Fee";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Due Date";
            this.Column6.Name = "Column6";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkMagenta;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1185, 935);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 74);
            this.button3.TabIndex = 10;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Location = new System.Drawing.Point(234, 1136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1778, 5);
            this.panel2.TabIndex = 102;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Britannic Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnX.Location = new System.Drawing.Point(1934, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(73, 42);
            this.btnX.TabIndex = 104;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimise.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimise.Location = new System.Drawing.Point(1858, 3);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(73, 42);
            this.btnMinimise.TabIndex = 103;
            this.btnMinimise.Text = "--";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkMagenta;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(1626, 935);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 74);
            this.button5.TabIndex = 105;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(663, 935);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 74);
            this.panel1.TabIndex = 106;
            // 
            // rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1900, 1044);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtid1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtdue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.txtcarid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rental";
            this.Text = "rental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtdue;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.ComboBox txtcarid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}