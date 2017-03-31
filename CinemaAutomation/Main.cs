using System;
using System.Drawing;
using System.Windows.Forms;
using CinemaAutomation.Models;
using CinemaAutomation.Controllers;
using CinemaAutomation.Views;

namespace CinemaAutomation
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            

            Film f = Global.AddFilm("Logan");
            Global.AddSeans(f, "1", DateTime.Parse("20/03/2017 12:00:00"));
            Global.AddSeans(f, "1", DateTime.Parse("20/03/2017 14:00:00"));

            foreach (Film filmR in Global.Films)
            {
                FilmComboBox.Items.Add(filmR.GetName());
            }

        }

        private void ShowSeats(Seans seans)
        {
            SeatsListPanel.Controls.Clear();

            foreach (Seat seat in seans.GetHall().GetSeats())
            {
                Button button = new Button();
                button.Tag = seat;
                if (seat.GetReservation())
                {
                    button.BackColor = Color.Green;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                button.Click += Button_Click;
                button.Text = seat.GetName();
                SeatsListPanel.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            Seat seat = (Seat)but.Tag;
            if (seat.GetReservation())
            {
                seat.SetReservation(false);
                but.BackColor = Color.Red;
            }
            else
            {
                seat.SetReservation(true);
                but.BackColor = Color.Green;
            }
        }

        private void FilmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Film selectedFilm = null;
            foreach (Film variable in Global.Films)
            {
                if (variable.GetName() == cb.SelectedItem.ToString())
                {
                    selectedFilm = variable;
                    break;
                }
            }

            seansEkleButton.Enabled = true;
            seansEkleButton.Tag = selectedFilm;

            SeanslarComboBox.Items.Clear();
            foreach (Seans seans in selectedFilm.GetSeanses())
            {
                SeanslarComboBox.Items.Add(seans.GetHall().GetHallName() + " - " + seans.GetStartTime().ToString("HH:mm"));
            }
        }

        private void SeanslarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            foreach (Seans seans in Global.Seanslar)
            {
                if (cb.SelectedItem.ToString() ==
                    seans.GetHall().GetHallName() + " - " + seans.GetStartTime().ToString("HH:mm"))
                {
                    ShowSeats(seans);
                    break;
                }
            }
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {
            AddFilm addFilm = new AddFilm();
            addFilm.ShowDialog();
            FilmComboBox.Items.Clear();

            foreach (Film filmR in Global.Films)
            {
                FilmComboBox.Items.Add(filmR.GetName());
            }
        }

        private void seansEkleButton_Click(object sender, EventArgs e)
        {
            Button seansButon = (Button) sender;
            Film selectedFilm = (Film)seansButon.Tag;
            Global.selectedFilm = selectedFilm;

            SeansAdd seansaddForm = new SeansAdd();
            seansaddForm.ShowDialog();

            SeanslarComboBox.Items.Clear();
            foreach (Seans seans in selectedFilm.GetSeanses())
            {
                SeanslarComboBox.Items.Add(seans.GetHall().GetHallName() + " - " + seans.GetStartTime().ToString("HH:mm"));
            }
        }
    }
}
