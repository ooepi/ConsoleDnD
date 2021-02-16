using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class UI
    {
        Game game = new Game();
        public void NextMove(Character character)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n1 - Show your stats");
            Console.WriteLine("2 - Fight");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                if (value == 1)
                {
                    character.GetStats();
                }
                else if (value == 2)
                {
                    game.Fight(character);
                }
            }
        }

        public void CreateCharacter(Character character)
        {
            Console.Write("What is your characters name: ");
            character.Name = Console.ReadLine();

            Console.WriteLine("\nChoose the race \n1 - Human\n2 - Orc\n3 - Elf\n4 - Undead\n");
            if (int.TryParse(Console.ReadLine(), out int value)) { value = character.Race; } 

            Console.WriteLine("\n\nChoose three stats to give boost to:\n(Maximum level is 10)\n");

            for (int i = 0; i < 3; i++)
            {
                character.CheckMaxStats();

                Console.WriteLine("\n1 - Strength:     " + character.Strength);
                Console.WriteLine("2 - Dexterity:    " + character.Dexterity);
                Console.WriteLine("3 - Constitution: " + character.Constitution);
                Console.WriteLine("4 - Intelligence: " + character.Intelligence);
                Console.WriteLine("5 - Charisma:     " + character.Charisma);
                Console.WriteLine("6 - Luck:         " + character.Luck + "\n");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    character.StatsBoost(choice);
                    if (choice < 1 || choice > 6) { i--; }
                }
            }

            character.CheckMaxStats();
            character.UpdateStatuses();

        }
    }
}
