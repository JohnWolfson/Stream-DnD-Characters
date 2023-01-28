using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace StreamDnDCharacters.Models
{
    class XMLProcessor
    {
        public CharacterData LoadData()
        {
            CharacterData characterData = new CharacterData();
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Environment.CurrentDirectory;
                dialog.Filter = "xml files (*.xml)|*.xml";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(characterData.GetType());
                    TextReader reader = new StreamReader(dialog.FileName);
                    characterData = (CharacterData)serializer.Deserialize(reader);
                    reader.Close();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error Loading File - " + Error.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return characterData;
        }
    }
}
