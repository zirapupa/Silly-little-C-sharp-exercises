using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class PocketCoins
    {
        public static void Run()
        {
            var coins = 0;
            var sum = 0;
            Console.WriteLine("You`ve got 5 pockets. Please enter amount of coins in each of it\nValid options are from 0 to 100");

            for (var pockets = 1; pockets <= 5; pockets++)
            {
                Console.Write($"How much money in your {pockets} pocket? Enter a number: ");
                coins = Convert.ToInt32(Console.ReadLine());

                if (coins < 0 || coins > 100)
                {
                    Console.WriteLine("Imposible amount of coins. Don`t lie to me. I know everything." +
                  $"\nAnd you will be punished for this. Now there are 0 coins in your {pockets} pocket" +
                  $"\n\t\"The DEV\"");
                }
                else
                {
                    sum += coins;
                    if (coins > 50)
                    {
                        Console.WriteLine("Wow, that`s a lot of coins!");
                    }
                }
            }

            var average = (double)sum / 5;
            Console.WriteLine($"\nWell, you`ve got {sum} coins in total\nAnd it`s {average} coins in average");
        }
    }
}
