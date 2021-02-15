using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class Character
    {
        Weapon w = null;


        //Basic characteristics
        string name;
        int level;
        string race;
        string alignment;

        //Stats
        int strength;
        int agility;
        int intelligence;
        int charisma;


        public void Init()
        {
            w = new Weapon();
        }
    }
}
