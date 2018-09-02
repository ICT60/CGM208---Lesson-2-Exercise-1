using System;

namespace CGM208___Lesson_2_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            short number = 0;
            decimal result = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");

                Console.WriteLine("Factorial of n");
                Console.Write("Please enter a number : ");

                string inputNum = Console.ReadLine();
                bool isCanParse = short.TryParse(inputNum, out number);

                if (isCanParse) {

                    try
                    {
                        result = Factorial(number);
                        Console.WriteLine("Result : {0}", result);

                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Do you want to quit? (y/n)");

                        string promptResult = Console.ReadLine();
                        isQuit = (promptResult.Equals("y") || promptResult.Equals("Y"));
                    }
                    catch (OverflowException exception)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("--- Error ---");
                        Console.WriteLine("Factorial of {0}", number);
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("The result is too high to be store.");
                        Console.WriteLine("--- Press enter to continue ---");
                        Console.WriteLine("------------------------------");
                        Console.Read();
                        continue;
                    }
                }

            } while (!isQuit);

            Console.Clear();
            Console.WriteLine("--- Press enter to exit ---");
            Console.ReadLine();
        }

        static decimal Factorial(decimal number)
        {
            if (number == 0) {
                return 1;
            }
            else {
                return number * Factorial(number - 1);
            }
        }
    }
}
