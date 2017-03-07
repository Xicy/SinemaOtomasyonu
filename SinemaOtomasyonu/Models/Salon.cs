using System.Collections.Generic;

namespace SinemaOtomasyonu.Models
{
    public class Salon
    {
        private readonly char[] Row = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
        private const byte Column = 18;

        private List<string> Chairs;

        public Salon()
        {
            Chairs = new List<string>();
            foreach (char val1 in Row)
            {
                for (byte val2 = 1; val2 <= 18; val2++)
                {
                    Chairs.Add(val1.ToString() + val2);
                }
            }
        }
    }
}
