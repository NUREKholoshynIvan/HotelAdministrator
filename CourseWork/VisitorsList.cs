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
    public partial class VisitorsList : Form
    {
        public VisitorsList()
        {
            InitializeComponent();
            string res = "";
            int k = 1;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    if(HotelAdministrator.hotel.Rooms[i, j].Occupied)
                    {
                        res += k + ". " + HotelAdministrator.hotel.Rooms[i, j].Visitor.GetData(1) + "\n";
                        k++;
                    }
                }
            }
            TextBox.Text = "Нема заселених відвідувачів.";
            if(res.Length > 0)
            {
                TextBox.Text = res;
            }
        }
    }
}
