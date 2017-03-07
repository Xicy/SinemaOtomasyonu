using System.Collections.Generic;

namespace CinemaAutomation.Models
{
    public class Hall
    {
        private readonly char[] Row = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };//TODO: ascii ile yapılabilir char A dan 26 karakter sonrasına kadar
        private const byte Column = 18;

        private List<string> Seats;

        public Hall()
        {
            Seats = new List<string>();
            foreach (char val1 in Row)
            {
                for (byte val2 = 1; val2 <= 18; val2++)
                {
                    Seats.Add(val1.ToString() + val2);
                }
            }
        }
    }
}
