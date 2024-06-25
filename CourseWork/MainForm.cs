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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewHotel_Click(object sender, EventArgs e)
        {
            HotelAdministrator form = new HotelAdministrator(null);
            form.ShowDialog();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadHotel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Load Hotel Data";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string hotelDataFile = openFileDialog.FileName;
                    MessageBox.Show("Hotel data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Add any additional code here to update the UI with the loaded hotel data
                    HotelAdministrator form = new HotelAdministrator(hotelDataFile);
                    form.ShowDialog();
                }
            }
        }
    }
}
