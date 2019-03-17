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
    public partial class Priority : Form
    {
        int[] importance;
        public Priority()
        {
            InitializeComponent();
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            lblThreadSize.Text = tbSize.Value.ToString() ;
        }
        private Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            createProgressBars();
            priority();
            timer1.Start();
        }

        public void priority()
        {
            Random rnd = new Random();
            int amountThreads = int.Parse(numUpDown.Value.ToString());
            importance = new int[amountThreads];

            for (int i = 0; i < amountThreads; i++)
            {
                importance[i] = rnd.Next(1, 4);
            }
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

        private void timer1_Tick(object sender, EventArgs e) // Kyk hier
        {
            int i = 1;
            int check = 4;
            bool containsNumber = importance.Contains(check);
            foreach (Control controls in groupBox1.Controls)
            {
                var progressBar = controls as ProgressBar;
                
                if (progressBar.Name == "Thread" + i.ToString() && importance[i] == check)
                {
                    MessageBox.Show(importance[i].ToString() + " " + MessageBox.Show(importance[i].ToString()));
                    progressBar.Step = 2;
                    progressBar.PerformStep();
                    System.Threading.Thread.Sleep(100);
                    importance[i] = 0;
                }
                if (!containsNumber)
                {
                    check--;
                    containsNumber = importance.Contains(check);
                }
                
                    
                
                i++;
            }
        }
    }
}
