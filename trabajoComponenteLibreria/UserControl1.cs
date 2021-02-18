using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace trabajoComponenteLibreria
{
    public partial class UserControl1: UserControl
    {
        Stopwatch stopwatch = new Stopwatch();
        List<string> listaTiempo = new List<string>();
        TimeSpan timespan;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            this.startButton.Enabled = false;
            this.stopButton.Enabled = true;
            this.vueltaButton.Enabled = true;
            this.restartButton.Enabled = true;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            this.stopButton.Enabled = false;
            this.startButton.Enabled = true;
        }

        private void vueltaButton_Click(object sender, EventArgs e)
        {
            this.listaTiempo.Add(String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds));
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = listaTiempo;

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.label1.Text = "00:00:00";
            this.listBox1.DataSource = null;
            this.startButton.Enabled = true;
            this.stopButton.Enabled = false;
            this.vueltaButton.Enabled = false;
            this.restartButton.Enabled = false;

            stopwatch.Stop();
            stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning) {
                timespan = stopwatch.Elapsed;
                this.label1.Text = String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes,timespan.Seconds,timespan.Milliseconds);
            }
        }
    }
}
