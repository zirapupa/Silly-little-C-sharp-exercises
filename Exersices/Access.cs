using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Access
    {
        public static void Run()
        {
            Console.WriteLine("Write your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            bool invalidAge = age < 0;
            bool isTooOld = age >= 110;
            bool hasAccess = age >= 18 && age <= 110;

            if (invalidAge)
            {
                Console.WriteLine("Invalid age");
            }
            else if (isTooOld)
            {
                Console.WriteLine("Did you really live that long?");
            }
            else if (hasAccess)
            {
                Console.WriteLine("Access permitted");
            }
            else
            {
                Console.WriteLine("You`re too young to watch this ;) Come later");
            }
        }
    }
}
