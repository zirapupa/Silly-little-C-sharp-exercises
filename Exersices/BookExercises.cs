using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class BookExercises
    {
        public static void Run()
        {
            int stamina = 35;
            int playerHP = 50;
            int monsterHP = 100;

            Console.WriteLine($"You encounter a monster! Prepare to fight!" +
                $"\nYour HP {playerHP}, Your stamina {stamina}\nMonster HP {monsterHP}\n");

            while (stamina > 0)
            {
                Console.Write("Enter action: (attack / heal / run): ");
                var action = Console.ReadLine().Trim().ToLower();

                switch (action)
                {
                    case "attack":
                        Console.WriteLine("Choose type of attack (kick / punch): ");
                        var attackType = Console.ReadLine().Trim().ToLower();
                        switch (attackType)
                        {
                            case "kick":
                                if (stamina < 3)
                                {
                                    Console.WriteLine("Not enough stamina to attack!");
                                    break;
                                }

                                monsterHP -= 15;
                                playerHP -= 5;
                                stamina -= 3;
                                Console.WriteLine("Monster got hit and lost 15 HP. " +
                                    "But you lost balance and the ground took 5 of your HP");
                                Console.WriteLine($"You used 3 stamina");

                                if (monsterHP > 0)
                                {
                                    Console.WriteLine("Monster attacks back and you lose 5 HP!");
                                    playerHP -= 5;
                                }
                                break;

                            case "punch":
                                if (stamina < 2)
                                {
                                    Console.WriteLine("Not enough stamina to attack!");
                                    break;
                                }

                                monsterHP -= 10;
                                stamina -= 2;
                                Console.WriteLine("You punch HARD! Monster lost 10 HP");
                                Console.WriteLine($"You used 2 stamina. Now you have {stamina} stamina left.");

                                if (monsterHP > 0)
                                {
                                    Console.WriteLine("Monster attacks back and you lose 5 HP!");
                                    playerHP -= 5;
                                }
                                break;

                            default:
                                Console.WriteLine("Unknown attack type");
                                break;
                        }
                        break;

                    case "heal":
                        if (stamina < 5)
                        {
                            Console.WriteLine("Not enough stamina to heal!");
                            break;
                        }

                        playerHP += 5;
                        Console.WriteLine("You restore 5 HP");
                        stamina -= 5;
                        Console.WriteLine($"You used 5 of your stamina. Now you have {stamina} stamina left.");

                        if (monsterHP > 0)
                        {
                            Console.WriteLine("Monster attacks you, while you heal and you lose 2 HP!");
                            playerHP -= 2;
                        }

                        break;

                    case "run":
                        Console.WriteLine("You escaped!");
                        return;

                    default:
                        Console.WriteLine("Unknown action");
                        break;
                }

                Console.WriteLine("\n--- STATUS ---");
                Console.WriteLine($"Your HP: {playerHP}, Stamina: {stamina}");
                Console.WriteLine($"Monster HP: {monsterHP}\n");

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
            Console.WriteLine("You are too tired to continue fighting!");
        }
    }
}