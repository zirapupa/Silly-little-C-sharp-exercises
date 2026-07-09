using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class EvenOrNot
    {
        public static void Run()
        {
            Console.WriteLine("Write your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isEven = number % 2 == 0;
            bool isPositive = number > 0;
            bool isInRange = number >= 1 && 100 >= number;

            Console.WriteLine("Is your number even? " + isEven);
            Console.WriteLine("Is your number posititv? " + isPositive);
            Console.WriteLine("Is your number in 1 to 100 range? " + isInRange);
        }
    }
}
