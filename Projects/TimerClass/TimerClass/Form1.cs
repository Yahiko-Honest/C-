using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int counter = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = counter;
            counter--;
            label1.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Fuck you");
                progressBar1.Refresh();
                counter = 60;
            }

            if (counter%2==1)
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = 60.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Interval = timer1.Interval / 2;
        }
    }
}
