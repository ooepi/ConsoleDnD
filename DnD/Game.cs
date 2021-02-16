using System;
using System.Collections.Generic;
using System.Text;

namespace DnD
{
    class Game
    {

        public void Start()
        {
            UI ui = new UI();
            Character player = new Character();
            player.Init("Player");
            ui.CreateCharacter(player);

            while (player.IsAlive)
            {
                ui.NextMove(player);
            }

        }

        public void Fight(Character player)
        {
            Character enemy = new Character();
            enemy.Init("Enemy");
            enemy.UpdateStatuses();

            Console.WriteLine($"{player.Name} stats:");
            player.GetStats();
            Console.WriteLine("Enemy's stats:");
            enemy.GetStats();

            Console.WriteLine("Press any key to start the fight..");
            Console.ReadKey();

            while (true)
            {
                int playerRoll = Die.Roll1d6();
                Console.Write($"\n\n\n{player.Name} roll: {playerRoll}, and hit for {playerRoll + player.Damage} \n\n");
                enemy.GetHit(playerRoll + player.Damage);
                Console.WriteLine($"{player.Name} HP: {player.Health} ------- {enemy.Name} HP: {enemy.Health}");

                if (!enemy.IsAlive)
                {
                    enemy.Death();
                    break;
                }

                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();

                int enemyRoll = Die.Roll1d6();
                Console.Write($"\n\n\nYour enemy rolls: {enemyRoll}, and hits for {enemyRoll + enemy.Damage} \n\n");
                player.GetHit(enemyRoll + enemy.Damage);
                Console.WriteLine("------------");
                Console.WriteLine($"{player.Name} HP: {player.Health} ------- {enemy.Name} HP: {enemy.Health}");
                Console.WriteLine("------------");

                if (!player.IsAlive)
                {
                    player.Death();
                    break;
                }

                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();

            }



        }
    }
}
