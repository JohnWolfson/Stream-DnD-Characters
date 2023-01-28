using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDnDCharacters.Models.Logic
{
    class CharacterController
    {
        private CharacterData characterData;

        public CharacterController()
        {
            
        }

        public CharacterDataCharacters[] GetCharacters()
        {
            return characterData.Characters;
        }

        public void LoadCharacters()
        {
            XMLProcessor xmlProc = new XMLProcessor();
            characterData = xmlProc.LoadData();
            foreach (CharacterDataCharacters character in characterData.Characters)
                character.ID = Guid.NewGuid().ToString();
        }

        public void UpdataCharacterStats(string ID, string newName = null, string newRace = null, string newClass = null, string newCurrentHP = null, string newMaxHP = null, string newAC = null, Image newPortrait = null)
        {
            for(int i = 0; i <= characterData.Characters.Length; i++)
            {
                if(ID == characterData.Characters[i].ID)
                {
                    if(newName != null)
                        characterData.Characters[i].Name = newName;
                    if(newRace != null)
                        characterData.Characters[i].Race = newRace;
                    if(newClass != null)
                        characterData.Characters[i].Class = newClass;
                    if(newCurrentHP != null)
                        characterData.Characters[i].HP.Current = Convert.ToByte(newCurrentHP);
                    if(newMaxHP != null)
                        characterData.Characters[i].HP.Max = Convert.ToByte(newMaxHP);
                    if (newAC != null)
                        characterData.Characters[i].AC = Convert.ToByte(newAC);
                    //if(newPortrait != null)
                        
                    break;
                }
            }
        }

        public string GetCharacterHPString(string ID)
        {
            foreach(CharacterDataCharacters character in characterData.Characters)
            {
                if(ID == character.ID)
                {
                    return character.HP.Current + "/" + character.HP.Max;
                }
            }
            return null;
        }
    }
}
