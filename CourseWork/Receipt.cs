using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Receipt : Form
    {
        public Receipt(int RoomNumber, int FloorNumber)
        {
            InitializeComponent();
            NameLabel.Text = HotelAdministrator.hotel.Rooms[FloorNumber - 1, RoomNumber - 1].Visitor.Name;
            Surname.Text = HotelAdministrator.hotel.Rooms[FloorNumber - 1, RoomNumber - 1].Visitor.Surname;
            Floor.Text = (FloorNumber).ToString();
            Room.Text = (RoomNumber).ToString();
            SettlingDateText.Text = (HotelAdministrator.hotel.Rooms[FloorNumber - 1, RoomNumber - 1].SettlingDate).ToString("dd-MM-yyyy");
            UnSettlingDateText.Text = (HotelAdministrator.hotel.Rooms[FloorNumber - 1, RoomNumber - 1].UnSettlingDate).ToString("dd-MM-yyyy");
            TimeSpan difference = HotelAdministrator.hotel.Rooms[FloorNumber - 1, RoomNumber - 1].UnSettlingDate - HotelAdministrator.hotel.Rooms[FloorNumber - 1, RoomNumber - 1].SettlingDate;
            PriceText.Text = ((difference.Days + 1) * HotelAdministrator.hotel.price).ToString();
        }
        public void SaveToFile(string receiptFilePath)
        {
            using (StreamWriter writer = new StreamWriter(receiptFilePath))
            {
                writer.WriteLine("Квитанція");
                writer.WriteLine("Ім'я: " + NameLabel.Text);
                writer.WriteLine("Фамілія: " + Surname.Text);
                writer.WriteLine("Етаж: " + Floor.Text);
                writer.WriteLine("Кімната: " + Room.Text);
                writer.WriteLine("Заселився: " + SettlingDateText.Text);
                writer.WriteLine("Виселяється: " + UnSettlingDateText.Text);
                writer.WriteLine("До сплати: " + PriceText.Text);
            }
            MessageBox.Show("Receipt saved to " + receiptFilePath);
        }
        public void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить квитанцию";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveToFile(saveFileDialog.FileName);
                }
            }
        }
    }
}
