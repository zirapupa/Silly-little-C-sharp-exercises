using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Calculator
    {
        public static void Run()
        {
            double result = 0;

            Console.WriteLine("Enter the first number: ");
            double rirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation (+, -, *, /, avg): ");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                result = rirstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = rirstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = rirstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Please, choose another operation.");
                    return;
                }
                result = rirstNumber / secondNumber;
            }
            else if (operation == "avg")
            {
                result = (rirstNumber + secondNumber) / 2;
                Console.WriteLine("Average of " + rirstNumber + " and " + secondNumber + " is " + result);
                return;
            }
            else
            {
                Console.WriteLine("Invalid operation. Please, choose one from the list above");
            }

            Console.WriteLine(rirstNumber + " " + operation + " " + secondNumber + " = " + result);
        }
    }
}
