namespace Group_Employee
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            monthCalendar1 = new MonthCalendar();
            menuStrip1 = new MenuStrip();
            sIGNOUTToolStripMenuItem = new ToolStripMenuItem();
            tIMEINOUTToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblFname = new Label();
            lblMname = new Label();
            lblLname = new Label();
            lblGender = new Label();
            lblOccupation = new Label();
            label14 = new Label();
            label15 = new Label();
            lblEmail = new Label();
            label16 = new Label();
            lblPhone = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 2);
            monthCalendar1.Location = new Point(954, 105);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sIGNOUTToolStripMenuItem, tIMEINOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1924, 41);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // sIGNOUTToolStripMenuItem
            // 
            sIGNOUTToolStripMenuItem.Name = "sIGNOUTToolStripMenuItem";
            sIGNOUTToolStripMenuItem.Size = new Size(154, 37);
            sIGNOUTToolStripMenuItem.Text = "SIGN OUT";
            // 
            // tIMEINOUTToolStripMenuItem
            // 
            tIMEINOUTToolStripMenuItem.Name = "tIMEINOUTToolStripMenuItem";
            tIMEINOUTToolStripMenuItem.Size = new Size(204, 37);
            tIMEINOUTToolStripMenuItem.Text = "TIME IN/OUT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1260, 72);
            label2.Name = "label2";
            label2.Size = new Size(279, 28);
            label2.TabIndex = 3;
            label2.Text = "ATTENDANCE CHECKER:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(831, 639);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1065, 321);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(831, 594);
            label3.Name = "label3";
            label3.Size = new Size(344, 33);
            label3.TabIndex = 5;
            label3.Text = "PAYROLL INFORMATIONS:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1275, 595);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 36);
            textBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1763, 594);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 285);
            label4.Name = "label4";
            label4.Size = new Size(191, 33);
            label4.TabIndex = 9;
            label4.Text = "09876543221";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 321);
            label5.Name = "label5";
            label5.Size = new Size(163, 28);
            label5.TabIndex = 10;
            label5.Text = "EMPLOYEE ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 411);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 11;
            label6.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 543);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 12;
            label7.Text = "Last Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 478);
            label8.Name = "label8";
            label8.Size = new Size(163, 28);
            label8.TabIndex = 13;
            label8.Text = "Middle Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 611);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 14;
            label9.Text = "Gender:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 675);
            label10.Name = "label10";
            label10.Size = new Size(134, 28);
            label10.TabIndex = 15;
            label10.Text = "Birth Date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 678);
            label11.Name = "label11";
            label11.Size = new Size(144, 28);
            label11.TabIndex = 16;
            label11.Text = "Occupation:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 364);
            label1.Name = "label1";
            label1.Size = new Size(300, 33);
            label1.TabIndex = 17;
            label1.Text = "Personal Information:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 759);
            label12.Name = "label12";
            label12.Size = new Size(109, 28);
            label12.TabIndex = 18;
            label12.Text = "Address:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 837);
            label13.Name = "label13";
            label13.Size = new Size(283, 33);
            label13.TabIndex = 19;
            label13.Text = "Contact Information:";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(17, 440);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(125, 28);
            lblFname.TabIndex = 20;
            lblFname.Text = "John Christ";
            // 
            // lblMname
            // 
            lblMname.AutoSize = true;
            lblMname.Location = new Point(17, 507);
            lblMname.Name = "lblMname";
            lblMname.Size = new Size(118, 28);
            lblMname.TabIndex = 21;
            lblMname.Text = "Villazorda";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(20, 576);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(74, 28);
            lblLname.TabIndex = 22;
            lblLname.Text = "Speed";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(21, 647);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 28);
            lblGender.TabIndex = 23;
            lblGender.Text = "Male";
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new Point(20, 719);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(225, 28);
            lblOccupation.TabIndex = 24;
            lblOccupation.Text = "Married and Divorce";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 794);
            label14.Name = "label14";
            label14.Size = new Size(359, 28);
            label14.TabIndex = 25;
            label14.Text = "San Jose, San Juan, Southern Leyte";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(21, 878);
            label15.Name = "label15";
            label15.Size = new Size(177, 28);
            label15.TabIndex = 26;
            label15.Text = "Email Address:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(205, 878);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(226, 28);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "JohnCVS@gmail.com";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(21, 912);
            label16.Name = "label16";
            label16.Size = new Size(183, 28);
            label16.TabIndex = 28;
            label16.Text = "Phone Number:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(205, 912);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(142, 28);
            lblPhone.TabIndex = 29;
            lblPhone.Text = "0987654321";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            ControlBox = false;
            Controls.Add(lblPhone);
            Controls.Add(label16);
            Controls.Add(lblEmail);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(lblOccupation);
            Controls.Add(lblGender);
            Controls.Add(lblLname);
            Controls.Add(lblMname);
            Controls.Add(lblFname);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(menuStrip1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sIGNOUTToolStripMenuItem;
        private ToolStripMenuItem tIMEINOUTToolStripMenuItem;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox1;
        private Button btnSearch;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label1;
        private Label label12;
        private Label label13;
        private Label lblFname;
        private Label lblMname;
        private Label lblLname;
        private Label lblGender;
        private Label lblOccupation;
        private Label label14;
        private Label label15;
        private Label lblEmail;
        private Label label16;
        private Label lblPhone;
    }
}