using System;

namespace Exercises
{
    internal class BookExercises
    {
        public static void Run()
        {
            Console.WriteLine("Create a password: ");
            string? password = Console.ReadLine();
            if (password == null)
            {
                Console.WriteLine("Invalid input. Please try again");
                return;
            }

            string? passwordCheck;

            Console.WriteLine("Now lets check if you still remember it: ");
            do
            {
                Console.Write("Enter your password: ");
                passwordCheck = Console.ReadLine();
                if (passwordCheck == null)
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
                if (passwordCheck != password)
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
            } while (passwordCheck != password);
            Console.WriteLine("Password correct!");
        }
    }
}