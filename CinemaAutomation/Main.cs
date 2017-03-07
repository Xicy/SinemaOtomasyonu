using System.Windows.Forms;
using CinemaAutomation.Models;

namespace CinemaAutomation
{
    public partial class Main : Form
    {
        private Hall salon;

        public Main()
        {
            InitializeComponent();
            salon = new Hall();
        }
    }
}
