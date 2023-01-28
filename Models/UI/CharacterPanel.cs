using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using StreamDnDCharacters.Models.Logic;

namespace StreamDnDCharacters.Models
{
    class CharacterPanel : SplitContainer
    {
        private CharacterController controller;
        private DisplayPanel displayPanel;
        private EditPanel editPanel;
        private string characterID;

        public CharacterPanel(CharacterController newController, CharacterDataCharacters newCharacter)
        {
            controller = newController;
            characterID = newCharacter.ID;
            displayPanel = new DisplayPanel(newCharacter);
            editPanel = new EditPanel(this, newCharacter);
            this.Size = new Size(200, 500);
            this.SplitterDistance = 250;
            this.IsSplitterFixed = true;
            this.Orientation = Orientation.Horizontal;
            this.AutoSize = true;
            this.Panel1.Controls.Add(displayPanel);
            this.Panel2.Controls.Add(editPanel);
        }

        public void NameTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string newName = (sender as TextBox).Text;
                controller.UpdataCharacterStats(characterID, newName: newName);
                displayPanel.UpdateName(newName);
            }
        }

        public void RaceTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string newRace = (sender as TextBox).Text;
                controller.UpdataCharacterStats(characterID, newRace: newRace);
                displayPanel.UpdateRace(newRace);
            }
        }

        public void ClassTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string newClass = (sender as TextBox).Text;
                controller.UpdataCharacterStats(characterID, newClass: newClass);
                displayPanel.UpdateClass(newClass);
            }
        }

        public void CurrentHPTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if(e.KeyChar == (char)Keys.Enter)
            {
                string newCurrentHP = (sender as TextBox).Text;
                controller.UpdataCharacterStats(characterID, newCurrentHP: newCurrentHP);
                displayPanel.UpdateHP(controller.GetCharacterHPString(characterID));
            }
        }

        public void MaxHPTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if(e.KeyChar == (char)Keys.Enter)
            {
                string newMaxHP = (sender as TextBox).Text;
                controller.UpdataCharacterStats(characterID, newMaxHP: newMaxHP);
                displayPanel.UpdateHP(controller.GetCharacterHPString(characterID));
            }
        }

        public void ACNumberChanged(object sender, EventArgs e)
        {
            string newAC = (sender as NumericUpDown).Value.ToString();
            controller.UpdataCharacterStats(characterID, newAC: newAC);
            displayPanel.UpdateAC(newAC);
        }
    }
}
