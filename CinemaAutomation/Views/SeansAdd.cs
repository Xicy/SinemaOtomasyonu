using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaAutomation.Controllers;
using CinemaAutomation.Models;

namespace CinemaAutomation.Views
{
    public partial class SeansAdd : Form
    {
        public SeansAdd()
        {
            InitializeComponent();

            startDateTimePicker.Value = DateTime.Now;
            foreach (Hall salon in Global.Halls)
            {
                if (!hallNameComboBox.Items.Contains(salon.GetHallName()))
                    hallNameComboBox.Items.Add(salon.GetHallName());
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime selectedTime = new DateTime(startDateTimePicker.Value.Year, startDateTimePicker.Value.Month, startDateTimePicker.Value.Day,startClockTimePicker.Value.Hour,startClockTimePicker.Value.Minute,startDateTimePicker.Value.Second);
            Global.AddSeans(Global.selectedFilm, hallNameComboBox.SelectedItem.ToString(), selectedTime);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
