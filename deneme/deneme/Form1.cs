using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;
using System.Diagnostics;
using System.Windows.Forms;


namespace deneme
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

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            string labeltext = txt_Box.Text;
            string fileName = @"sonuc";

            var doc = DocX.Create(fileName);

            doc.InsertParagraph("Iscinin adi: " + labeltext);

            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
