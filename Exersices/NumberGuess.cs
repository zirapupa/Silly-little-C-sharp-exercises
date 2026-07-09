using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class NumberGuess
    {
        public static void Run()
        {
            int numberToGuess = new Random().Next(1, 11);
            int attempt;
            int userGuess;
            int attemptsLeft = 3;

            Console.WriteLine("Guess the number between 1 and 10");

            for (attempt = 1; attempt <= 3; attempt++)
            {
                attemptsLeft--;
                Console.Write("Attempt " + attempt + ": ");

                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == numberToGuess)
                {
                    Console.WriteLine("You guessed it right and won!");
                    return;
                }
                else
                {
                    if (attemptsLeft == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Try again, you have " + attemptsLeft + " more attempt(s)");
                }
            }

            Console.WriteLine("Oh, I`m sorry but you lose");
        }
    }
}
