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
    public partial class HotelAdministrator : Form
    {
        public static Hotel hotel = new Hotel();
        public HotelAdministrator(string FilePath)
        {
            InitializeComponent();
            if(FilePath == null)
            {
                hotel.CreateHotel();
                TodayDate.Text = hotel.ThisDay.ToString("dd-MM-yyyy");
            }
            else
            {
                hotel = Hotel.LoadFromFile(FilePath);
            }
            TodayDate.Text = hotel.ThisDay.ToString("dd-MM-yyyy");
        }

        private void SettleButton_Click(object sender, EventArgs e)
        {
            SettlingForm form = new SettlingForm();
            form.ShowDialog();
        }

        private void VisitorsList_Click(object sender, EventArgs e)
        {
            VisitorsList f = new VisitorsList();
            f.ShowDialog();
        }

        private void UnSettleButton_Click(object sender, EventArgs e)
        {
            UnsettlingForm form = new UnsettlingForm();
            form.ShowDialog();
        }

        private void SkipDay_Click(object sender, EventArgs e)
        {
            hotel.NextDay();
            TodayDate.Text = hotel.ThisDay.ToString("dd-MM-yyyy");
        }

        private void UnsettlingTodayButton_Click(object sender, EventArgs e)
        {
            UnsettlingTodayForm form = new UnsettlingTodayForm();
            form.ShowDialog();
        }

        private void AddDaysButton_Click(object sender, EventArgs e)
        {
            AddDaysForm form = new AddDaysForm();
            form.ShowDialog();
        }

        private void RoomsList_Click(object sender, EventArgs e)
        {
            RoomsList form = new RoomsList();
            form.ShowDialog();
        }

        private void SearchVisitorsButton_Click(object sender, EventArgs e)
        {
            FindVisitors form = new FindVisitors();
            form.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Hotel Data";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hotel.SaveToFile(saveFileDialog.FileName);
                    MessageBox.Show("Hotel data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
