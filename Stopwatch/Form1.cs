using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class dsgnStopwatch : Form
    {
        int timeMs, timeSec, timeMin;
        bool isActive;

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTimer();
        }

        private void ResetTimer()
        {
            timeMs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive==true)
            {
                timeMs++;

                if (timeMs>=100)
                {
                    timeSec++;
                    timeMs = 0;

                    if (timeSec>=60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }

            DrawTime();

        }

        private void DrawTime()
        {
            lblMs.Text = String.Format("{0:00}", timeMs);
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);
        }

        public dsgnStopwatch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTimer();

            isActive = false;
        }
    }
}
