using System;
using System.Collections.Generic;
using CinemaAutomation.Models;

namespace CinemaAutomation.Controllers
{
    public static class Global
    {
        public static List<Film> Films = new List<Film>();
        public static List<Seans> Seanslar = new List<Seans>();
        public static List<Hall> Halls = new List<Hall>();

        public static Film AddFilm(string name)
        {
            Film f = new Film(name);
            Films.Add(f);
            return f;
        }

        public static void RemoveFilm(Film film)
        {



            Films.Remove(film);
        }

        public static Hall AddHall(string name)
        {
            Hall h = new Hall(name);
            Halls.Add(h);
            return h;
        }

        public static void RemoveHall(Hall hall)
        {
            Halls.Remove(hall);
        }

        public static void AddSeans(Film film, string hallName, DateTime startTime)
        {
            Seans seans = new Seans(startTime,AddHall(hallName));
            film.AddSeans(seans);
            Seanslar.Add(seans);
        }

        public static void RemoveSeans(Film film,Seans seans)
        {
            film.RemoveSeans(seans);
            Seanslar.Remove(seans);
        }
    }
}
