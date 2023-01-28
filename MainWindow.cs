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
using StreamDnDCharacters.Models.Logic;


namespace StreamDnDCharacters
{
    public partial class MainWindow : Form
    {
        CharacterController controller;
        private GUI UI;

        public MainWindow()
        {
            InitializeComponent();
            controller = new CharacterController();
            UI = new GUI(controller);
            this.Controls.Add(UI.GetMainPanel());
            this.Controls.Add(UI.GetMenuStrip());
            this.Text = "D&D Twitch Character Control Panel";
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
