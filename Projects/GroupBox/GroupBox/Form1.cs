using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        string Combo_Machine;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başlık bu neye tıklıyorsun!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                radioButton3.Checked = false;
            }
            else { radioButton3.Checked = true; }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Degistirildi");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Combobox değiştirildi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Combo_Machine = comboBox1.SelectedItem.ToString();

            switch (Combo_Machine)
            {
                case "brr":
                    MessageBox.Show(Combo_Machine+" way kardeşim");
                    break;
                case "skrr":
                    MessageBox.Show(Combo_Machine+" bunun ne demek olduğunu biliyorsun");
                    break;
                case "ksssssssa":
                    MessageBox.Show(Combo_Machine+" vur kış kış kış kış");
                    break;
                case "300 500":
                    MessageBox.Show(Combo_Machine+" Müzik aç müziiiiiiiiiiik");
                    break;

            }
        }
    }
}
