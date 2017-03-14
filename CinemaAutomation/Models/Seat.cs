
namespace CinemaAutomation.Models
{
    public class Seat
    {
        private string _name;
        private bool rev;

        public Seat(string name)
        {
            _name = name;
            rev = false;
        }

        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Rezervasyonu ayarla
        /// </summary>
        /// <param name="status">True ise rezerve edilmiş</param>
        public void SetReservation(bool status)
        {
            rev = status;
        }

        /// <summary>
        /// Rezervasyon durumunu al
        /// </summary>
        /// <returns>True ise rezerve edilmiş</returns>
        public bool GetReservation()
        {
            return rev;
        }
    }
}
