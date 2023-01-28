using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDnDCharacters.Models
{
    class DisplayPanel : FlowLayoutPanel
    {
        private Label nameLabel;
        private Label raceLabel;
        private Label classLabel;
        private Label HPLabel;
        private Label ACLabel;
        private PictureBox portraitBox;

        public DisplayPanel(CharacterDataCharacters newCharacter)
        {
            this.FlowDirection = FlowDirection.TopDown;
            this.Dock = DockStyle.Fill;
            nameLabel = initialiseLabel("Name: " + newCharacter.Name);
            raceLabel = initialiseLabel("Race: " + newCharacter.Race);
            classLabel = initialiseLabel("Class: " + newCharacter.Class);
            HPLabel = initialiseLabel("HP: " + newCharacter.HP.Current + "/" + newCharacter.HP.Max);
            ACLabel = initialiseLabel("AC: " + newCharacter.AC.ToString());
            this.Controls.Add(nameLabel);
            this.Controls.Add(raceLabel);
            this.Controls.Add(classLabel);
            this.Controls.Add(HPLabel);
            this.Controls.Add(ACLabel);
        }

        private Label initialiseLabel(string newText)
        {
            Label newLabel = new Label();
            newLabel.Text = newText;
            return newLabel;
        }

        public void UpdateStats(string newName = null, string newRace = null, string newClass = null, string newHP = null, string newAC = null, Image newPotrait = null)
        {
            if (newName != null)
                UpdateName(newName);
            if (newRace != null)
                UpdateRace(newRace);
            if (newClass != null)
                UpdateClass(newClass);
            if (newHP != null)
                UpdateHP(newHP);
            if (newAC != null)
                UpdateAC(newAC);
            if (newPotrait != null)
                UpdatePotrait(newPotrait);
        }

        public void UpdateName(string newName)
        {
            nameLabel.Text = "Name: " + newName;
        }

        public void UpdateRace(string newRace)
        {
            raceLabel.Text = "Race: " + newRace;
        }

        public void UpdateClass(string newClass)
        {
            classLabel.Text = "Class: " + newClass;
        }

        public void UpdateHP(string newHP)
        {
            HPLabel.Text = "HP: " + newHP;
        }

        public void UpdateAC(string newAC)
        {
            ACLabel.Text = "AC: " + newAC;
        }

        public void UpdatePotrait(Image newPotrait)
        {
            portraitBox.Image = newPotrait;
        }
    }
}
