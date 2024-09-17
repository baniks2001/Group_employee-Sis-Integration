namespace Group_Employee
{
    partial class TimeInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeInOut));
            menuStrip1 = new MenuStrip();
            sIGNOUTToolStripMenuItem = new ToolStripMenuItem();
            dASHBOARDToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDate = new Label();
            lblTime = new Label();
            btnTimeIn = new Button();
            btnTimeOut = new Button();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            lblCountdown = new Label();
            lblCount = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sIGNOUTToolStripMenuItem, dASHBOARDToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1924, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sIGNOUTToolStripMenuItem
            // 
            sIGNOUTToolStripMenuItem.Name = "sIGNOUTToolStripMenuItem";
            sIGNOUTToolStripMenuItem.Size = new Size(133, 32);
            sIGNOUTToolStripMenuItem.Text = "SIGN OUT";
            sIGNOUTToolStripMenuItem.Click += sIGNOUTToolStripMenuItem_Click;
            // 
            // dASHBOARDToolStripMenuItem
            // 
            dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            dASHBOARDToolStripMenuItem.Size = new Size(170, 32);
            dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            // 
            // listView1
            // 
            listView1.Location = new Point(1000, 220);
            listView1.Name = "listView1";
            listView1.Size = new Size(895, 797);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1000, 159);
            label1.Name = "label1";
            label1.Size = new Size(328, 52);
            label1.TabIndex = 2;
            label1.Text = "INFORMATION:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 49);
            label2.Name = "label2";
            label2.Size = new Size(248, 47);
            label2.TabIndex = 3;
            label2.Text = "TIME CLOCK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(294, 109);
            label3.Name = "label3";
            label3.Size = new Size(245, 37);
            label3.TabIndex = 4;
            label3.Text = "CURRENT DATE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(296, 220);
            label4.Name = "label4";
            label4.Size = new Size(243, 37);
            label4.TabIndex = 5;
            label4.Text = "CURRENT TIME:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Cambria", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Red;
            lblDate.Location = new Point(114, 159);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(136, 52);
            lblDate.TabIndex = 6;
            lblDate.Text = "label5";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Cambria", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Red;
            lblTime.Location = new Point(279, 266);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(136, 52);
            lblTime.TabIndex = 7;
            lblTime.Text = "label5";
            // 
            // btnTimeIn
            // 
            btnTimeIn.BackColor = Color.MidnightBlue;
            btnTimeIn.FlatStyle = FlatStyle.Popup;
            btnTimeIn.Font = new Font("Cambria", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeIn.ForeColor = Color.AliceBlue;
            btnTimeIn.Location = new Point(40, 793);
            btnTimeIn.Name = "btnTimeIn";
            btnTimeIn.Size = new Size(360, 159);
            btnTimeIn.TabIndex = 8;
            btnTimeIn.Text = "TIME IN";
            btnTimeIn.UseVisualStyleBackColor = false;
            btnTimeIn.Click += btnTimeIn_Click;
            // 
            // btnTimeOut
            // 
            btnTimeOut.BackColor = Color.Red;
            btnTimeOut.FlatStyle = FlatStyle.Popup;
            btnTimeOut.Font = new Font("Cambria", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeOut.ForeColor = Color.White;
            btnTimeOut.Location = new Point(432, 793);
            btnTimeOut.Name = "btnTimeOut";
            btnTimeOut.Size = new Size(360, 159);
            btnTimeOut.TabIndex = 9;
            btnTimeOut.Text = "TIME OUT";
            btnTimeOut.UseVisualStyleBackColor = false;
            btnTimeOut.Click += btnTimeOut_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 677);
            label5.Name = "label5";
            label5.Size = new Size(208, 37);
            label5.TabIndex = 10;
            label5.Text = "EMPLOYEE ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(279, 619);
            label6.Name = "label6";
            label6.Size = new Size(282, 52);
            label6.TabIndex = 11;
            label6.Text = "0987654321";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountdown.ForeColor = Color.Red;
            lblCountdown.Location = new Point(457, 744);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(32, 33);
            lblCountdown.TabIndex = 13;
            lblCountdown.Text = "0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(289, 746);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(164, 28);
            lblCount.TabIndex = 14;
            lblCount.Text = "COUNTDOWN:";
            // 
            // TimeInOut
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            ControlBox = false;
            Controls.Add(lblCount);
            Controls.Add(lblCountdown);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnTimeOut);
            Controls.Add(btnTimeIn);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TimeInOut";
            Text = "TimeInOut";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sIGNOUTToolStripMenuItem;
        private ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDate;
        private Label lblTime;
        private Button btnTimeIn;
        private Button btnTimeOut;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label lblCountdown;
        private Label lblCount;
    }
}