/*Name: Blake Jensen
  Program Purpose: Marks converted to Grade*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks___Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program's function is to generate a grade after given a certain mark.");
            Console.Write("Please enter the final mark you received: ");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Congratulations! You fully scored on your whatever you took\n(good english right?) Regardless you scored a solid A+! Good work!");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Good work! You scored enough for an A!");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("A B+, pretty good. Keep it up!");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("B. Still better than a B, but you could do better!");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("That's a C, average score, keep trying harder.");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("D...not good, just passing by. You'll need to study more..");
            else if (mark >= 0 && mark <= 39)
                Console.WriteLine("F...thats really bad, did you even study for this??");
            else
                Console.WriteLine("Whoops! There was a problem with the answer you entered there!");

            Console.WriteLine("Great! this task is now over, press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
