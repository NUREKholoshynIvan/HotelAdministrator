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
    public partial class UnsettlingForm : Form
    {
        public static int RoomNumber = 1;
        public static int Floor = 1;
        List<Button> buttons = new List<Button>();
        public UnsettlingForm()
        {
            InitializeComponent();
            AddAllButtons();
            ChangeFloor(0);
        }
        public void Change(System.Windows.Forms.Button button, bool color)
        {
            if (color)
            {
                button.BackColor = Color.Red;
                button.Enabled = true;
            }
            else
            {
                button.BackColor = Color.LightGreen;
                button.Enabled = false;
            }
        }
        public void ChangeFloor(int floor)
        {
            for (int i = 0; i < 16; i++)
            {
                Change(buttons[i], HotelAdministrator.hotel.Rooms[floor, i].Occupied);
            }
        }

        private void FloorRoomReload(int num)
        {
            RoomNumber = num;
            Floor = Decimal.ToInt32(numericUpDown1.Value);
            RoomText.Text = RoomNumber.ToString();
            FloorText.Text = Floor.ToString();
            NameLabel.Text = HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.Name;
            SurnameLabel.Text = HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.Surname;
            VisitorsNumber.Text = HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.VisitorsNumber.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            FloorRoomReload(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 2;
            FloorRoomReload(num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 3;
            FloorRoomReload(num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 4;
            FloorRoomReload(num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 5;
            FloorRoomReload(num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = 6;
            FloorRoomReload(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 7;
            FloorRoomReload(num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = 8;
            FloorRoomReload(num);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 9;
            FloorRoomReload(num);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int num = 10;
            FloorRoomReload(num);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = 11;
            FloorRoomReload(num);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int num = 12;
            FloorRoomReload(num);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int num = 13;
            FloorRoomReload(num);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int num = 14;
            FloorRoomReload(num);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int num = 15;
            FloorRoomReload(num);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int num = 16;
            FloorRoomReload(num);
        }
        public void AddAllButtons()
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangeFloor(Decimal.ToInt32(numericUpDown1.Value) - 1);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(FloorText.Text == "-")
            {
                MessageBox.Show("Не вдалося виселити: не вказаний номер.");
            }
            else
            {
                HotelAdministrator.hotel.UnSettle(Floor, RoomNumber);
                Receipt receipt = new Receipt(RoomNumber, Floor);
                receipt.ShowDialog();
                this.Close();
            }
        }
    }
}
