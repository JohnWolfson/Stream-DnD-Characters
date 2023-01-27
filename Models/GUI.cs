using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDnDCharacters.Models
{
    class GUI
    {
        public MainMenu MenuStrip; 

        public GUI(MainWindow window)
        {
            MenuStrip = new MainMenu(window);
        }
    }
}
