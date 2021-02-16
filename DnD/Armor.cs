using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class Armor
    {
        //1-9 Leather
        //10-19 Iron
        //20-29 Steel
        //30-39 Obsidian
        //40 Legendary

        private string name;
        private int armorValue;
        private int durability;
        private bool isBroken;

        public string Name { get => name; set => name = value; }
        public int ArmorValue { get => armorValue; set => armorValue = value; }
        public int Durability { get => durability; set => durability = value; }
        public bool IsBroken { get => isBroken; set => isBroken = value; }


        public void GenerateRandomArmor()
        {
            ArmorValue = Die.Roll1d20() + Die.Roll1d20();

            if (ArmorValue > 1 && ArmorValue <= 9) { Name = "Leather Armor"; }
            if (ArmorValue > 10 && ArmorValue <= 19) { Name = "Iron Armor"; }
            if (ArmorValue > 20 && ArmorValue <= 29) { Name = "Steel Armor"; }
            if (ArmorValue > 30 && ArmorValue <= 39) { Name = "Obsidian Armor"; }
            if (ArmorValue == 40 ){ Name = "Legendary Armor"; }

            Durability = 100;
            IsBroken = false;
        }

        public void CheckDurability()
        {
            if (Durability <= 0)
            {
                IsBroken = true;
            }
        }
    }
}
