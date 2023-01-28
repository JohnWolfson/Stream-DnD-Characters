using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StreamDnDCharacters.Models.Logic;

namespace StreamDnDCharacters.Models
{
    class EditPanel : FlowLayoutPanel
    {
        private CharacterPanel parent;
        private TextBox nameTextBox;
        private TextBox raceTextBox;
        private TextBox classTextBox;
        private TextBox currentHPTextBox;
        private TextBox maxHPTextBox;
        private NumericUpDown ACNumeric;
        private Button portraitButton;

        public EditPanel(CharacterPanel newParent, CharacterDataCharacters newCharacter)
        {
            parent = newParent;
            this.Dock = DockStyle.Fill;
            this.FlowDirection = FlowDirection.TopDown;
            this.BackColor = Color.LightGray;
            initialiseInputs(newCharacter);
            addControlsToPanel();
        }
        
        #region Initialise Components

        private void initialiseInputs(CharacterDataCharacters newCharacter)
        {
            nameTextBox = initialiseNameTextBox(newCharacter);
            raceTextBox = initialiseRaceTextBox(newCharacter);
            classTextBox = initialiseClassTextBox(newCharacter);
            currentHPTextBox = initialiseCurrentHPTextBox(newCharacter);
            maxHPTextBox = initialiseMaxHPTextBox(newCharacter);
            ACNumeric = initialiseACNumeric(newCharacter);
            portraitButton = initialisePortraitButton(newCharacter);
        }

        private void addControlsToPanel()
        {
            this.Controls.Add(nameTextBox);
            this.Controls.Add(raceTextBox);
            this.Controls.Add(classTextBox);
            this.Controls.Add(currentHPTextBox);
            this.Controls.Add(maxHPTextBox);
            this.Controls.Add(ACNumeric);
            this.Controls.Add(portraitButton);
        }

        private TextBox initialiseNameTextBox(CharacterDataCharacters newCharacter)
        {
            TextBox textBox = new TextBox();
            textBox.Text = newCharacter.Name;
            textBox.KeyPress += new KeyPressEventHandler(parent.NameTextBoxKeyPress);
            return textBox;
        }

        private TextBox initialiseRaceTextBox(CharacterDataCharacters newCharacter)
        {
            TextBox textBox = new TextBox();
            textBox.Text = newCharacter.Race;
            textBox.KeyPress += new KeyPressEventHandler(parent.RaceTextBoxKeyPress);
            return textBox;
        }

        private TextBox initialiseClassTextBox(CharacterDataCharacters newCharacter)
        {
            TextBox textBox = new TextBox();
            textBox.Text = newCharacter.Class;
            textBox.KeyPress += new KeyPressEventHandler(parent.ClassTextBoxKeyPress);
            return textBox;
        }

        private TextBox initialiseCurrentHPTextBox(CharacterDataCharacters newCharacter)
        {
            TextBox textBox = new TextBox();
            textBox.Text = newCharacter.HP.Current.ToString();
            textBox.KeyPress += new KeyPressEventHandler(parent.CurrentHPTextBoxKeyPress);
            return textBox;
        }

        private TextBox initialiseMaxHPTextBox(CharacterDataCharacters newCharacter)
        {
            TextBox textBox = new TextBox();
            textBox.Text = newCharacter.HP.Max.ToString();
            textBox.KeyPress += new KeyPressEventHandler(parent.MaxHPTextBoxKeyPress);
            return textBox;
        }

        private NumericUpDown initialiseACNumeric(CharacterDataCharacters newCharacter)
        {
            NumericUpDown numeric = new NumericUpDown();
            numeric.Value = newCharacter.AC;
            numeric.ValueChanged += new EventHandler(parent.ACNumberChanged);
            return numeric;
        }

        private Button initialisePortraitButton(CharacterDataCharacters newCharacter)
        {
            Button button = new Button();
            return button;
        }

        #endregion
    }
}
