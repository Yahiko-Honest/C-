using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        string sdaf;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sdaf = firstButton.Text;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            firstButton.Text = "Changed";

        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            firstButton.Text = sdaf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "first label";
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
        }
    }
}
