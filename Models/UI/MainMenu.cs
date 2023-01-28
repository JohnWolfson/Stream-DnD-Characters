using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamDnDCharacters.Models.Logic;

namespace StreamDnDCharacters.Models
{
    class MainMenu : MenuStrip
    {
        private GUI parent;

        public MainMenu(GUI newGUI)
        {
            parent = newGUI;
            this.Dock = DockStyle.Top;
            this.Items.Add(getFileItem());
        }

        private ToolStripMenuItem getFileItem()
        {
            ToolStripMenuItem file = new ToolStripMenuItem();
            file.Text = "File";
            file.DropDownItems.Add(getLoadItem());
            return file;
        }

        private ToolStripMenuItem getLoadItem()
        {
            ToolStripMenuItem load = new ToolStripMenuItem();
            load.Text = "Load Characters";
            load.Click += new EventHandler(parent.LoadFile);
            return load;
        }
    }
}
