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
    public partial class UnsettlingTodayForm : Form
    {
        public UnsettlingTodayForm()
        {
            InitializeComponent();
            ReloadText();
        }
        public void ReloadText()
        {
            string res = "";
            int k = 1;
            foreach(Room room in HotelAdministrator.hotel.UnsettlingToday)
            {
                res += k + ". " + room.Visitor.GetData(0) + "\n";
                k++;
            }
            TextBox.Text = "Нема відвідувачів, що виселяються сьогодні.";
            if (res.Length > 0)
            {
                TextBox.Text = res;
            }
        }
    }
}
