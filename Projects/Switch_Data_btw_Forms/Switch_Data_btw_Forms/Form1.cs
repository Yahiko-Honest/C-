﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Data_btw_Forms
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*frmShowData frmShow = new frmShowData();
            frmShow.ShowDialog();*/

            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            String NameSurname = Name + " " + Surname;
            frmShowData frmShow = new frmShowData();
            frmShow.lblNameSurname.Text = NameSurname;
            frmShow.Show();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
