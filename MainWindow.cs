using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamDnDCharacters.Models;

namespace StreamDnDCharacters
{
    public partial class MainWindow : Form
    {
        private GUI UI;
        private Characters characters;

        public MainWindow()
        {
            InitializeComponent();
            characters = new Characters();
            UI = new GUI(this);
            this.Controls.Add(UI.MenuStrip);
        }

        public void LoadCharacterData(object sender, EventArgs e)
        {
            XMLProcessor xmlProc = new XMLProcessor();
            characters = xmlProc.LoadData();
        }
    }
}
