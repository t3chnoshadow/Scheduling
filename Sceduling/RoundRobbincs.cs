using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sceduling
{
    public partial class RoundRobbin : Form
    {
        int[] arrSize;
        int time = 0;
        public RoundRobbin()
        {
            InitializeComponent();
        }

        int[] RandomSizes(int ArrLength, int maxInt)
        {
            int[] arr = new int[ArrLength];
            Random rnd = new Random();
            for (int i=0; i<ArrLength;i++)
            {
                arr[i] = rnd.Next(maxInt);
            }
            return arr;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            createProgressBars();
            arrSize = new int[int.Parse(numUpDown.Value.ToString())];
            arrSize = RandomSizes(int.Parse(numUpDown.Value.ToString()), int.Parse(lblThreadSize.Text));
            timer1.Start();


        }

        public void createProgressBars()
        {
            int amount;
            amount = int.Parse(numUpDown.Value.ToString());

            for (int i = 1; i <= amount; i++)
            {
                ProgressBar threadProgressBar = new ProgressBar();
                threadProgressBar.Width = 500;
                threadProgressBar.Height = 50;
                threadProgressBar.Maximum = int.Parse(lblThreadSize.Text);
                threadProgressBar.Minimum = 1;
                threadProgressBar.Name = "Thread" + i.ToString();
                if (i <= 5)
                {
                    if (i == 1)
                    {
                        threadProgressBar.Location = new Point(50, 100);
                    }
                    else
                    {
                        threadProgressBar.Location = new Point(50, 100 * i);
                    }
                }
                else
                {
                    if (i == 6)
                    {
                        threadProgressBar.Location = new Point(600, 100);
                    }
                    else
                    {
                        threadProgressBar.Location = new Point(600, 100 * (i - 5));
                    }
                }
                
                
                threadProgressBar.Visible = true;
                groupBox1.Controls.Add(threadProgressBar);
                
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblThreadSize.Text = trackBar1.Value.ToString();
        }

        private void RoundRobbin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            int i = 1;
            foreach (Control control in groupBox1.Controls)
            {

                
                var progressBar = control as ProgressBar;
                if ((progressBar.Name == "Thread" + i.ToString()) && (time <=5) && (progressBar.Value < arrSize[i-1]))
                {
                    progressBar.Step = 2;
                    progressBar.PerformStep();
                    System.Threading.Thread.Sleep(100);
                }
                i++;
                time = 0;
                
                //timer1.Stop();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
