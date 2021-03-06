﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class Weapon
    {
        //1-9 Wooden
        //10-19 Iron
        //20-29 Steel
        //30-39 Obsidian
        //40 Legendary

        private string name;
        private int attack;
        private int durability;
        private bool isBroken;

        public string Name { get => name; set => name = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Durability { get => durability; set => durability = value; }
        public bool IsBroken { get => isBroken; set => isBroken = value; }


        public void GenerateRandomWeapon()
        {
            Attack = Die.Roll1d20() + Die.Roll1d20();

            if (Attack > 1 && Attack <= 9) { Name = "Wooden Sword"; }
            if (Attack > 10 && Attack <= 19) { Name = "Iron Sword"; }
            if (Attack > 20 && Attack <= 29) { Name = "Steel Sword"; }
            if (Attack > 30 && Attack <= 39) { Name = "Obsidian Sword"; }
            if (Attack == 40) { Name = "Legendary Sword"; }

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
