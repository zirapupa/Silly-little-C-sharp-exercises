using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class EnergyGame
    {
        public static void Run()
        {
            int energy = 10;
            int steps = 0;

            Console.WriteLine($"You have {energy} energy");

            while (true)
            {
                Console.WriteLine("Write your number of steps from 1 to 10: ");
                steps = Convert.ToInt32(Console.ReadLine().Trim());
                if (steps < 1 || steps > 10)
                {
                    Console.WriteLine("Invalid number of steps. Please enter a number from 1 to 10.");
                }
                else
                {
                    energy -= steps;
                    if (energy < 0)
                    {
                        energy = 0;
                    }
                    Console.WriteLine($"You`ve got {energy} energy left");

                    if (energy > 5)
                    {
                        Console.WriteLine("You feel great!");
                    }
                    else if (energy > 0 && energy < 5)
                    {
                        Console.WriteLine("You feel tired");
                    }
                    else
                    {
                        Console.WriteLine("You feel exhausted");
                        break;
                    }
                }
            }
        }
    }
}
