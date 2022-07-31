using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            string allvalid = "qwertyuıopğüasdfghjklşizxcvbnmöç";
            string result = "";
            Random rnd2 = new Random();

            for (int i = 0; i < 6; i++)
            {
                result += allvalid[rnd2.Next(0, Convert.ToInt32(allvalid.Length))];
            }

            label1.Text = result;
            

        }
    }
}
