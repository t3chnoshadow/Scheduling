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
        public RoundRobbin()
        {
            InitializeComponent();
        }

        int[] RandomSizes(int ArrLength, int maxInt)
        {
            int[] arr = new int[ArrLength];
            Random rnd = new Random(maxInt);
            for (int i=0; i<ArrLength;i++)
            {
                arr[i] = rnd.Next();
            }
            return arr;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            createScrolleBars(); 
        }

        public void createScrolleBars()
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
                Controls.Add(threadProgressBar);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblThreadSize.Text = trackBar1.Value.ToString();
        }

        private void RoundRobbin_Load(object sender, EventArgs e)
        {

        }
    }
}
