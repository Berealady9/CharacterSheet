using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CharacterSheet.Models
{
    public class Character
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public List<Equipment> Equipment { get; set; }
        public static void Create(string characterName)
        {
            var character = new Character();
            character.Name = characterName;
            //if (GlobalVariables.Characters == null)
            //    GlobalVariables.Characters = new List<Character>();
            GlobalVariables.Character.Add(character);
        }

        public static List<Character> GetAll()
        {
            return GlobalVariables.Character;
        }

    }

    public class Equipment
    {
    }
}
