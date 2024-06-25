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
    public partial class RoomsList : Form
    {
        public RoomsList()
        {
            InitializeComponent();
            ReloadTextBox();
        }
        public void ReloadTextBox()
        {
            List<Room> SettledRooms = new List<Room>();
            List<Room> UnsettledRooms = new List<Room>();
            foreach(Room room in HotelAdministrator.hotel.Rooms)
            {
                if(room.Occupied)
                {
                    SettledRooms.Add(room);
                } else
                {
                    UnsettledRooms.Add(room);
                }
            }

            string res = "";
            if(SettledRooms.Count > 0)
            {
                res += "Список заселених номерів:\n";
                foreach (Room room in SettledRooms)
                {

                    res += $"Етаж {room.Floor} кімната {room.RoomNumber};\n";
                }
            }
            else
            {
                res += "Заселених кімнат немає.\n";
            }
            if (UnsettledRooms.Count > 0)
            {
                res += "Список незаселених номерів:\n";
                foreach (Room room in UnsettledRooms)
                {

                    res += $"Етаж {room.Floor} кімната {room.RoomNumber};\n";
                }
            }
            else
            {
                res += "Незаселених кімнат немає.";
            }
            TextBox.Text = res;
        }
    }
}
