using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SettlingForm : Form
    {
        public static int RoomNumber = 1;
        public static int Floor = 1;
        public static int Days = 1;
        List<Button> buttons = new List<Button>();
        public SettlingForm()
        {
            InitializeComponent();
            AddAllButtons();
            ChangeFloor(0);
            DateChange(1);
        }
        public void DateChange(int days)
        {
            Days = days;
            SettlingUntil.Text = HotelAdministrator.hotel.ThisDay.AddDays(Days).ToString("dd-MM-yyyy");
        }
        
        public void Change(System.Windows.Forms.Button button, bool color)
        {
            if(color)
            {
                button.BackColor = Color.Red;
                button.Enabled = false;
            }
            else
            {
                button.BackColor = Color.LightGreen;
                button.Enabled = true;
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(RoomText.Text == "-")
            {
                MessageBox.Show("Помилка при заселенні: не вибрана кімната.");
            }
            else
            {
                if(NameTextBox.Text == "" || SurnameTextBox.Text == "")
                {
                    MessageBox.Show("Помилка при заселенні: не вказане ім'я або фамілія.");
                }
                else
                {
                    if(PassportTextBox.Text == "")
                    {
                        MessageBox.Show("Помилка при заселенні: не вказаний номер паспорту.");
                    }
                    else
                    {
                        List<Visitor> visitors = new List<Visitor>();
                        switch (VisitorsNumber.Value)
                        {
                            case 1:
                                Single vis1 = new Single();
                                visitors.Add(vis1);
                                break;
                            case 2:
                                Couple vis2 = new Couple();
                                vis2.SecondName = NameTextBox2.Text;
                                vis2.SecondSurname = SurnameTextBox2.Text;
                                visitors.Add(vis2);
                                break;
                            default:
                                Squad visS = new Squad();
                                visS.squadNames.Add(NameTextBox2.Text);
                                visS.squadSurnames.Add(SurnameTextBox2.Text);
                                visS.squadNames.Add(NameTextBox3.Text);
                                visS.squadSurnames.Add(SurnameTextBox3.Text);

                                if (VisitorsNumber.Value == 4)
                                {
                                    visS.squadNames.Add(NameTextBox4.Text);
                                    visS.squadSurnames.Add(SurnameTextBox4.Text);
                                }
                                visitors.Add(visS);
                                break;
                        }
                        HotelAdministrator.hotel.Settle(Floor, RoomNumber, visitors[0], Days);
                        HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.Name = NameTextBox.Text;
                        HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.Surname = SurnameTextBox.Text;
                        HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.Passport = PassportTextBox.Text;
                        HotelAdministrator.hotel.Rooms[Floor - 1, RoomNumber - 1].Visitor.VisitorsNumber = Decimal.ToInt32(VisitorsNumber.Value);

                        Receipt receipt = new Receipt(RoomNumber, Floor);
                        receipt.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangeFloor(Decimal.ToInt32(numericUpDown1.Value)-1);
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

        private void DaysToSettle_ValueChanged(object sender, EventArgs e)
        {
            Days = Decimal.ToInt32(DaysToSettle.Value);
            DateChange(Days);
        }
    }
}
