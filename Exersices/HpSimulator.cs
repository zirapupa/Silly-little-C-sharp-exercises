using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class HpSimulator
    {
        public static void Run()
        {
            int playerHP = 30;
            int monsterHP = 100;

            while (playerHP > 0)
            {
                Console.WriteLine("\nChoose your attack: \"kick\" or \"punch\"");
                string playerInput = Console.ReadLine();
                playerInput = playerInput.ToLower().Trim();

                if (playerInput == "kick")
                {
                    monsterHP = monsterHP - 15;
                    playerHP -= 5;
                    Console.WriteLine("Monster got hit and lost 15 HP. But you lost balance and the ground took 5 of your HP");
                    Console.WriteLine($"Your HP: {playerHP}\nMonster HP: {monsterHP}");
                }
                else if (playerInput == "punch")
                {
                    monsterHP -= 10;
                    Console.WriteLine("You punch HARD! Monster lost 10 HP");
                    Console.WriteLine($"Your HP: {playerHP}\nMonster HP: {monsterHP}");
                }
                else
                {
                    Console.WriteLine("Wrong move. Write \"kick\" or \"punch\"");
                }

                if (monsterHP <= 0 && playerHP <= 0)
                {
                    Console.WriteLine("Well, you defeated him. But lost all your HP in process");
                    break;
                }
                else if (monsterHP <= 0)
                {
                    Console.WriteLine("You defeated the monster!");
                    break;
                }
                else if (playerHP <= 0)
                {
                    Console.WriteLine("Oh no! You lost all your HP kicking that scum");
                    break;
                }

            }
        }
    }
}
