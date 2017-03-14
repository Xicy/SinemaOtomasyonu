using System.Collections.Generic;

namespace CinemaAutomation.Models
{
    public class Hall
    {
        private const byte Column = 18;

        private List<Seat> Seats;
        private string Name;

        public Hall(string name)
        {
            Name = name;
            Seats = new List<Seat>();
            for (int val1 = 0; val1 < 26; val1++)
            {
                for (byte val2 = 1; val2 <= 18; val2++)
                {
                    Seats.Add(new Seat(GetRow(val1).ToString() + val2));
                }
            }
        }

        public string GetHallName()
        {
            return Name;
        }

        public List<Seat> GetSeats()
        {
            return Seats;
        }

        private char GetRow(int row)
        {
            char value = 'A';
            char ret = (char)((byte)value + row % 26);
            return ret;
        }
    }
}
