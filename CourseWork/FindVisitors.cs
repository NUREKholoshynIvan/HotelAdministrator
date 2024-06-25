using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FindVisitors : Form
    {
        public FindVisitors()
        {
            InitializeComponent();
        }

        private void NameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(NameCheckBox.Checked)
            {
                NameToSearch.Enabled = true;
            }
            else
            {
                NameToSearch.Enabled = false;
                NameToSearch.Text = null;
            }
        }

        private void SurameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SurameCheckBox.Checked)
            {
                SurnameToSearch.Enabled = true;
            }
            else
            {
                SurnameToSearch.Enabled = false;
                SurnameToSearch.Text = null;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Visitor> visitors = new List<Visitor>();
            visitors = HotelAdministrator.hotel.FindVisitors(NameToSearch.Text,SurnameToSearch.Text);
            string res = "";
            int k = 1;
            if(visitors.Count > 0 )
            {
                foreach (Visitor visitor in visitors)
                {
                    res += $"{k}. {visitor.Name} {visitor.Surname}.\n";
                    k++;
                }
            }
            else
            {
                res = "Відвідувачів за введенними даними не знайдено.";
            }
            TextBox.Text = res;
        }
    }
}
