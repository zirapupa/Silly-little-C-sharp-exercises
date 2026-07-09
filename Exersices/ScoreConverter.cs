using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class ScoreConverter
    {
        public static void Run()
        {
            Console.Write("Enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Invalid input. Please enter your real score");
                return;
            }

            string grade;
            string comment;

            if (score < 60)
            {
                grade = "F"; comment = "You need to work harder";
            }
            else if (score < 75)
            {
                grade = "D"; comment = "You can do better";
            }
            else if (score < 85)
            {
                grade = "C"; comment = "Not bad!";
            }
            else if (score < 95)
            {
                grade = "B"; comment = "Good job!";
            }
            else
            {
                grade = "A"; comment = "Excellent work!";
            }

            Console.WriteLine($"Score: {score}\nGrade: {grade}\nComment: {comment}");
        }
    }
}
