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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoundRobbin roundRobbin = new RoundRobbin();
            roundRobbin.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Priority p = new Priority();
            p.Show();
           // this.Hide();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Priority p = new Priority();
            p.Show();
           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiple_quess m = new Multiple_quess();
            m.Show();
        }
    }
}
