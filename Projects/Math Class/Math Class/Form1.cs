using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Class
{
    public partial class txtFirstNumber : Form
    {
        public txtFirstNumber()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar!='.')&&(e.KeyChar!='-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        double firstNumber = 0, secondNumber = 0;
        bool control = false;

        void set1Parameter(string text)
        {
            if (text.Trim()!="")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            control = false;
            textBox1.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }
        string Message = "Please fill the neccassary area";
        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(textBox1.Text,txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Min(Convert.ToDecimal(firstNumber),Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(textBox1.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Abs(firstNumber).ToString();
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Sign(firstNumber).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 180;
                txtResult.Text = Math.Sin(temp).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 180;
                txtResult.Text = Math.Cos(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                double temp = (firstNumber * (Math.PI)) / 180;
                txtResult.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Parameter(textBox1.Text,txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Pow(firstNumber,secondNumber).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Sqrt(firstNumber).ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Parameter(textBox1.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Log(firstNumber, secondNumber).ToString();
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Log10(firstNumber).ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            set1Parameter(textBox1.Text);
            if (!control)
            {
                MessageBox.Show(Message);
            }
            else
            {
                txtResult.Text = Math.Exp(firstNumber).ToString();
            }
        }

        private void btnCopyFirstNumber_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim()!="")
            {
                textBox1.Text = txtResult.Text;
                txtResult.Clear();
                txtSecondNumber.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void set2Parameter(string text,string text2)
        {
            if (text.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);
            }
        }
    }
}
