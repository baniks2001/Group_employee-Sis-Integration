using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Employee
{
    public partial class TimeInOut : Form
    {
        private System.Windows.Forms.Timer countdownTimer;
        private int countdownTime;
        private System.Windows.Forms.Timer timer;
        public TimeInOut()
        {
            InitializeComponent();
            InitializeTimer();
            UpdateDateTimeLabels();

            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // Timer ticks every second
            countdownTimer.Tick += CountdownTimer_Tick;

            // Initialize countdown time
            countdownTime = 10;
            lblCountdown.Visible = false;
            lblCount.Visible = false;
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            countdownTime--;

            lblCountdown.Text = countdownTime.ToString();

            if (countdownTime <= 0)
            {
                countdownTimer.Stop();
                // Re-enable the buttons
                btnTimeIn.Enabled = true;
                btnTimeOut.Enabled = true;

                lblCountdown.Visible = false;
                lblCount.Visible = false;
            }
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabels();
        }

        private void UpdateDateTimeLabels()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            btnTimeIn.Enabled = false;
            btnTimeOut.Enabled = false;

       
            countdownTime = 10; 
            lblCountdown.Text = countdownTime.ToString();
            lblCountdown.Visible = true;
            lblCount.Visible = true;
            countdownTimer.Start();
        }

        private void sIGNOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            btnTimeIn.Enabled = false;
            btnTimeOut.Enabled = false;

            
            countdownTime = 10; 
            lblCountdown.Text = countdownTime.ToString();
            lblCountdown.Visible = true;
            lblCount.Visible = true;
            countdownTimer.Start();
        }
    }
}
