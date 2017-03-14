
using System.Collections.Generic;

namespace CinemaAutomation.Models
{
    public class Film
    {
        private List<Seans> seanslar;
        private string _Name;

        public Film(string Name)
        {
            _Name = Name;
            seanslar = new List<Seans>();
        }

        public string GetName()
        {
            return _Name;
        }

        /// <summary>
        /// Seans ekleme
        /// </summary>
        /// <param name="seans"></param>
        public void AddSeans(Seans seans)
        {
            seanslar.Add(seans);
        }

        /// <summary>
        /// seans silme
        /// </summary>
        /// <param name="seans"></param>
        public void RemoveSeans(Seans seans)
        {
            seanslar.Remove(seans);
        }
    }
}
