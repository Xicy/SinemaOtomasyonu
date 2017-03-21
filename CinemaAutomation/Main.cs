using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CinemaAutomation.Models;

namespace CinemaAutomation
{
    public partial class Main : Form
    {
        private List<Film> Films;
        private List<Seans> Seanslar;
        private List<Hall> Halls;

        public Main()
        {
            InitializeComponent();

            Films = new List<Film>();
            Seanslar = new List<Seans>();
            Halls = new List<Hall>();

            Halls.Add(new Hall("1"));
            Halls.Add(new Hall("1"));

            Film film = new Film("Logan");

            Seans seans = new Seans(DateTime.Parse("20/03/2017 12:00:00"), Halls[0]);
            Seans seans2 = new Seans(DateTime.Parse("20/03/2017 14:00:00"), Halls[1]);
            Seanslar.Add(seans2);
            film.AddSeans(seans2);
            Seanslar.Add(seans);
            film.AddSeans(seans);

            Films.Add(film);

            foreach (Film filmR in Films)
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
            foreach (Film variable in Films)
            {
                if (variable.GetName() == cb.SelectedItem.ToString())
                {
                    selectedFilm = variable;
                    break;
                }
            }

            SeanslarComboBox.Items.Clear();
            foreach (Seans seans in selectedFilm.GetSeanses())
            {
                SeanslarComboBox.Items.Add(seans.GetHall().GetHallName() + " - " + seans.GetStartTime().ToString("HH:mm"));
            }
        }

        private void SeanslarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox) sender;
            foreach (Seans seans in Seanslar)
            {
                if (cb.SelectedItem.ToString() ==
                    seans.GetHall().GetHallName() + " - " + seans.GetStartTime().ToString("HH:mm"))
                {
                    ShowSeats(seans);
                    break;
                }
            }
        }
    }
}
