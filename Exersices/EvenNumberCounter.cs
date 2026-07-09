using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class EvenNumberCounter
    {
        public static void Run()
        {
            Console.Write("Write number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int evenCounter = 0;

            Console.Write("Even numbers are:");

            for (int i = 1; i <= number; i++)
            {
                bool isEven = i % 2 == 0;
                if (isEven)
                {
                    evenCounter++;
                    Console.Write(" " + i);
                }
            }

            Console.WriteLine("\nThere are {0} even numbers between 1 and {1}", evenCounter, number);
        }
    }
}
