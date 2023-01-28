using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamDnDCharacters.Models.Logic;

namespace StreamDnDCharacters.Models
{
    class GUI
    {
        private CharacterController controller;
        private MainMenu menuStrip;
        private MainPanel mainPanel;

        public GUI(CharacterController newController)
        {
            controller = newController;
            menuStrip = new MainMenu(this);
            mainPanel = new MainPanel(newController);
        }

        public MainMenu GetMenuStrip()
        {
            return menuStrip;
        }

        public MainPanel GetMainPanel()
        {
            return mainPanel;
        }

        public void LoadFile(object sender, EventArgs e)
        {
            controller.LoadCharacters();
            mainPanel.ClearCharacterPanels();
            foreach (CharacterDataCharacters character in controller.GetCharacters())
            {
                CharacterPanel newCharacterPanel = new CharacterPanel(controller, character);
                mainPanel.AddNewCharacterPanel(newCharacterPanel);
            }
        }
    }
}
