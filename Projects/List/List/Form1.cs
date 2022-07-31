using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>();
        List<days> combo_List = new List<days>();

        public List<Employee> fillList()
        {
            employeeList.Clear();

            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Robin";
            employee1.Surname = "EKMEN";
            employeeList.Add(employee1);

            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Roni";
            employee2.Surname = "Özdemir";
            employeeList.Add(employee2);

            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Said";
            employee3.Surname = "EKMEN";
            employeeList.Add(employee3);
            return employeeList;

            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            days day1 = new days();
            day1.Id = 1;
            day1.textvalue = "Sunday";
            combo_List.Add(day1);

            days day2 = new days();
            day2.Id = 2;
            day2.textvalue = "Monday";
            combo_List.Add(day2);

            days day3 = new days();
            day3.Id = 3;
            day3.textvalue = "Tuesday";
            combo_List.Add(day3);

            days day4 = new days();
            day4.Id = 4;
            day4.textvalue = "Wednesday";
            combo_List.Add(day4);

            days day5 = new days();
            day5.Id = 5;
            day5.textvalue = "Thursday";
            combo_List.Add(day5);

            days day6 = new days();
            day6.Id = 6;
            day6.textvalue = "Friday";
            combo_List.Add(day6);

            days day7 = new days();
            day7.Id = 7;
            day7.textvalue = "Saturday";
            combo_List.Add(day7);

            cmbDays.DataSource = combo_List;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textvalue";
            daylist.DataSource = combo_List;
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var item in combo_List)
            {
                
                txtNumber.Text += item.Id + " " + item.textvalue + " " + Environment.NewLine;
            }
            //MessageBox.Show("List was filled ");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void daylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
