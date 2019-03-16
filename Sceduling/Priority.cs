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
        public Priority()
        {
            InitializeComponent();
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            lblsize.Text = tbSize.Value.ToString() ;
        }
        private Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            ProgressBar bars = new ProgressBar();
            bars.Width = 100;
            bars.Height = 20;
            bars.Location = new System.Drawing.Point(12, 130);
            bars.Maximum = tbSize.Value;
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));//https://stackoverflow.com/questions/29198073/get-random-color
            bars.ForeColor = Color.DeepSkyBlue;
           
            bars.Value = bars.Maximum/2;
            Controls.Add(bars);

        }
    }
}
