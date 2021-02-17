using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class Character
    {
        Weapon weapon = null;
        Armor armor = null;


        //Basic characteristics
        private string name;
        private int level;
        private int race; //1 = Human, 2 = Orc, 3 = Elf, 4 = Undead

        //Stats
        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int charisma;
        private int luck;

        //Currents
        private int defence;
        private int health;

        private int damage;

        private bool isAlive;

        //Props

        public string Name {
            get { return name; }
            set { name = value; } 
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Race
        {
            get { return race; }
            set { race = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Constitution { get => constitution; set => constitution = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Charisma { get => charisma; set => charisma = value; }
        public int Luck { get => luck; set => luck = value; }


        public int Defence { get => defence; set => defence = value; }
        public int Health { get => health; set => health = value; }
        public int Damage { get => damage; set => damage = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }

        public void Init(string name)
        {
            Name = name;
            IsAlive = true;
            //Stats
            Strength = 1 + Die.Roll1d6();
            Dexterity = 1 + Die.Roll1d6();
            Constitution = 1 + Die.Roll1d6();
            intelligence = 1 + Die.Roll1d6();
            Charisma = 1 + Die.Roll1d6();
            Luck = 1 + Die.Roll1d6();

            Health = 20 + Die.Roll1d20();

            weapon = new Weapon();
            weapon.GenerateRandomWeapon();

            armor = new Armor();
            armor.GenerateRandomArmor();

        }

        public void UpdateStatuses()
        {
            Damage = weapon.Attack/2 + Strength;
            Health += Constitution * 3;
        }

        public void CheckMaxStats()
        {
            if(Strength > 10) { Strength = 10; }
            if(Dexterity > 10) { Dexterity = 10; }
            if(Constitution > 10) { Constitution = 10; }
            if(Intelligence > 10) { Intelligence = 10; }
            if(Charisma > 10) { Charisma = 10; }
            if(Luck > 10) { Luck = 10; }
        }

        public void StatsBoost(int choice)
        {
            if (Race == 1)
            {
                Dexterity += 2;
            } else if (race == 2)
            {
                Strength += 2;
            } else if (race == 3)
            {
                Intelligence += 2;
            } else if (race == 4)
            {
                Constitution += 2;
            }

            switch (choice)
            {
                case 1:
                    Strength += 3;
                    break;
                case 2:
                    Dexterity += 3;
                    break;
                case 3:
                    Constitution += 3;
                    break;
                case 4:
                    Intelligence += 3;
                    break;
                case 5:
                    Charisma += 3;
                    break;
                case 6:
                    Luck += 3;
                    if (Luck > 8)
                    {
                        if (Die.Roll1d20() > 18)
                        {
                            Strength += 1;
                            Dexterity += 1;
                            Constitution += 1;
                            Intelligence += 1;
                            Charisma += 1;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Choose a number between 1 and 6");
                    break;
            }
        }

        public void GetHit(int damage)
        {

            MusicBox.SwingSound();
            Health -= damage;
            if (Health <= 0)
            {
                Death();
            }
        }

        public void Death()
        {
            IsAlive = false;
            Console.WriteLine($"{name} died..");
        }

        public void GetStats()
        {
            Console.WriteLine($@"

Health: {health}

Armor: {armor.Name}, Defence: {armor.ArmorValue}
Weapon: {weapon.Name}, Attack: {weapon.Attack}

Strenght: {strength}
Dexterity: {dexterity}
Constitution: {constitution}
Intelligence: {intelligence}
Charisma: {charisma}
Luck: {luck}");
        }
    }
}
