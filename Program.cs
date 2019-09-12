/* 
 * This C# Console Application code is meant to
 * ask the user what grade they expect in their ISM course,
 * receive an integer value and display the corresponding letter grade.
 * It also provides an option to help calculate the expected grade number
 * if the user does not already have it prepared.
 */
using System;

namespace ISM4300ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks for user input
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            Console.WriteLine("Please enter an integer value between 0 and 100");
            Console.WriteLine("If you need help calculating your overall grade enter the integer 999 instead");

            try
            {
                string input = Console.ReadLine();
                string leading = "Your grade is: ";
                decimal new_grade = 0;

                int grade = int.Parse(input);

                // This section helps calculate the overall grade value in not already prepared
                if (grade == 999)
                {
                    Console.WriteLine("What was your total percentage for each section?");
                    Console.WriteLine("Please enter an integer value between 0 and 100");
                    Console.Write("Class Participation: ");
                    int part = int.Parse(Console.ReadLine());
                    Console.Write("Weekly Deliverables: ");
                    int deliv = int.Parse(Console.ReadLine());
                    Console.Write("Class Project: ");
                    int proj = int.Parse(Console.ReadLine());
                    Console.Write("Case Studies: ");
                    int cases = int.Parse(Console.ReadLine());

                    int clear = 0;

                    // these series of IF statements are meant to check if the input values are within range
                    if ((part >= 0) && (part <= 100))
                    {
                        clear += 1;
                    }
                    if ((deliv >= 0) && (deliv <= 100))
                    {
                        clear += 1;
                    }
                    if ((proj >= 0) && (proj <= 100))
                    {
                        clear += 1;
                    }
                    if ((cases >= 0) && (cases <= 100))
                    {
                        clear += 1;
                    }

                    if (clear == 4)
                    {
                        new_grade = (part * 0.1m) + (deliv * 0.4m) + (proj * 0.1m) + (cases * 0.4m);
                        // rounds up for decimal value
                        int rounded = (int)Math.Round(new_grade, MidpointRounding.AwayFromZero);
                        Console.WriteLine("Your overall grade is: " + rounded.ToString());
                        Console.WriteLine("Please enter this value next time...");
                    }
                    else
                    {
                        Console.WriteLine("That's no good. One of your values is not an integer between 0 and 100");
                        Console.WriteLine("Please do so next time...");
                    }

                }
                else if ((grade < 101) && (grade > 97))
                {
                    Console.WriteLine(leading + "A+");
                }
                else if ((grade < 98) && (grade > 91))
                {
                    Console.WriteLine(leading + "A");
                }
                else if ((grade < 92) && (grade > 89))
                {
                    Console.WriteLine(leading + "A-");
                }
                else if ((grade < 90) && (grade > 87))
                {
                    Console.WriteLine(leading + "B+");
                }
                else if ((grade < 88) && (grade > 81))
                {
                    Console.WriteLine(leading + "B");
                }
                else if ((grade < 82) && (grade > 79))
                {
                    Console.WriteLine(leading + "B-");
                }
                else if ((grade < 80) && (grade > 77))
                {
                    Console.WriteLine(leading + "C+");
                }
                else if ((grade < 78) && (grade > 71))
                {
                    Console.WriteLine(leading + "C");
                }
                else if ((grade < 72) && (grade > 69))
                {
                    Console.WriteLine(leading + "C-");
                }
                else if ((grade < 70) && (grade > 67))
                {
                    Console.WriteLine(leading + "D+");
                }
                else if ((grade < 68) && (grade > 61))
                {
                    Console.WriteLine(leading + "D");
                }
                else if ((grade < 62) && (grade > 59))
                {
                    Console.WriteLine(leading + "D-");
                }
                else if (grade < 60)
                {
                    Console.WriteLine(leading + "F");
                }
                else
                {
                    Console.WriteLine("Please enter an integer value between 0 and 100 next time...");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value between 0 and 100 next time...");
            } // end of catch
        }
    }
}
