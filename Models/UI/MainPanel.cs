using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamDnDCharacters.Models.Logic;

namespace StreamDnDCharacters.Models
{
    class MainPanel : FlowLayoutPanel
    { 
        public MainPanel(CharacterController newController)
        {
            this.FlowDirection = FlowDirection.LeftToRight;
            this.Dock = DockStyle.Fill;
            this.Padding = new Padding(20, 20, 20, 20);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MinimumSize = new System.Drawing.Size(200, 100);
        }

        public void AddNewCharacterPanel(CharacterPanel newPanel)
        {
            this.Controls.Add(newPanel);
        }

        public void ClearCharacterPanels()
        {
            this.Controls.Clear();
        }
    }
}
