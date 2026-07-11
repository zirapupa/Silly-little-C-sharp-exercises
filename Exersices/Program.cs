using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose Task to run: ");
                Console.WriteLine("1. Book Exercises");
                Console.WriteLine("2. Number Guess");
                Console.WriteLine("3. Calculator");
                Console.WriteLine("4. Even or not?");
                Console.WriteLine("5. Is access permitted?");
                Console.WriteLine("6. Even Number Counter");
                Console.WriteLine("7. Score Converter");
                Console.WriteLine("8. HP Simulator");
                Console.WriteLine("9. Coins in your pockets");
                Console.WriteLine("10. Energy game");
                Console.WriteLine("11. Boss Fight");
                Console.WriteLine("Type 'Exit' to quit the program");
                Console.Write("Your choice: ");

                string? rawInput = Console.ReadLine();
                if (rawInput == null)
                {
                    Console.WriteLine("Invalid input. Please choose from the variant above");
                    continue;
                }
                else if (rawInput.Trim().ToLower() == "menu")
                {
                    continue;
                }

                string input = rawInput.Trim().ToLower();

                if (input == "exit")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                else if (input == "1")
                {
                    Console.WriteLine();
                    BookExercises.Run();
                }
                else if (input == "2")
                {
                    Console.WriteLine();
                    NumberGuess.Run();
                }
                else if (input == "3")
                {
                    Console.WriteLine();
                    Calculator.Run();
                }
                else if (input == "4")
                {
                    Console.WriteLine();
                    EvenOrNot.Run();
                }
                else if (input == "5")
                {
                    Console.WriteLine();
                    Access.Run();
                }
                else if (input == "6")
                {
                    Console.WriteLine();
                    EvenNumberCounter.Run();
                }
                else if (input == "7")
                {
                    Console.WriteLine();
                    ScoreConverter.Run();
                }
                else if (input == "8")
                {
                    Console.WriteLine();
                    HpSimulator.Run();
                }
                else if (input == "9")
                {
                    Console.WriteLine();
                    PocketCoins.Run();
                }
                else if (input == "10")
                {
                    Console.WriteLine();
                    EnergyGame.Run();
                }
                else if (input == "11")
                {
                    Console.WriteLine();
                    BossFight.Run();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose from the variant above");
                }
            }
        }
    }
}
