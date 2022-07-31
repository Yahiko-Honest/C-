using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void HideRadioButtons()
        {
            groupBox1.Visible = false;
        }

        public void ShowRadioButtons()
        {
            groupBox1.Visible = true;
        }

        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                HideRadioButtons();
            }
            else if (groupBox1.Visible == false)
            {
                ShowRadioButtons();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void FillTextBox(string text)
        {
            textBox2.Text = text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillTextBox(textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SetNumber(int age)
        {
            label1.Text = "You are " + age.ToString() + " years old!";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SetNumber(45);
        }
    }
}
