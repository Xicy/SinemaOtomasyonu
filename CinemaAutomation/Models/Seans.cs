using System;

namespace CinemaAutomation.Models
{
    public class Seans
    {
        private DateTime time;
        private Hall hall;

        public Seans(DateTime startTime, Hall filmHall)
        {
            time = startTime;
            hall = filmHall;
        }

        public Hall GetHall()
        {
            return hall;
        }

        public DateTime GetStartTime()
        {
            return time;
        }
    }
}
