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
    public partial class Multiple_quess : Form
    {
        public Multiple_quess()
        {
            InitializeComponent();
        }
        int[] que;
        int[] importance;
        int[] arrSize;


        private void tbSize_Scroll(object sender, EventArgs e)
        {
            lblThreadSize.Text = trackBar1.Value.ToString();
        }
        private Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            createProgressBars();
            priority();
            timer1.Start();
            arrSize = RandomSizes(int.Parse(numUpDown.Value.ToString()), trackBar1.Value);
        }

        int[] RandomSizes(int ArrLength, int maxInt)
        {
            int[] arr = new int[ArrLength];
            Random rnd = new Random();
            for (int i = 0; i < ArrLength; i++)
            {
                arr[i] = rnd.Next(maxInt);
            }
            return arr;
        }

        public void priority()
        {
            Random rnd = new Random();
            int amountThreads = int.Parse(numUpDown.Value.ToString());
            importance = new int[amountThreads];
            que = new int[amountThreads];

            for (int i = 0; i < amountThreads; i++)
            {
                importance[i] = rnd.Next(1, 4);
                que[i] = rnd.Next(1, 4);
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
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e) // Kyk hier
        {


            time++;
            int i = 1;
            foreach (Control control in groupBox1.Controls)
            {

                int max = importance.Max();//https://stackoverflow.com/questions/4906725/largest-and-smallest-number-in-an-array
                int nextQue = que.Min();
                var progressBar = control as ProgressBar;
                if (nextQue < 11) { 
                    //if (max != -1)
                    //{
                    lblprio.Text = "Current Priority: " + max.ToString();
                lblQue.Text = "current que: " + nextQue.ToString();
                if ((progressBar.Name == "Thread" + i.ToString()) && (time <= 5) && (progressBar.Value < arrSize[i - 1]) && (nextQue == que[i - 1]))
                {
                    if (max == importance[i - 1] )
                    {
                        progressBar.Step = 2;
                        progressBar.PerformStep();
                        System.Threading.Thread.Sleep(100);
                    }

                    if (progressBar.Value >= arrSize[i - 1])
                    {
                        importance[i - 1] = -1;
                        que[i - 1] = 11;
                    }
                }
                i++;
                time = 0;
            }
                
                else
                {
                    timer1.Stop();
                    MessageBox.Show("done");
                } } }
                //timer1.Stop();
            
         
    }
}

