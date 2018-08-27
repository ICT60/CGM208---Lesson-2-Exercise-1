using System;

namespace CGM208___Lesson_2_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;

            do
            {
                Console.Write("Please enter a number : ");
                string inputNum = Console.ReadLine();

                double number = 0;
                bool isCanParse = double.TryParse(inputNum, out number);

                if (isCanParse) {

                    double result = Factorial(number);
                    Console.WriteLine("Result : {0}", result);

                    Console.WriteLine("Do you want to quit? (y/n)");
                    string promptResult = Console.ReadLine();

                    if (promptResult.Equals("y")) {
                        isQuit = true;
                    }
                    else {
                        continue;
                    }
                }
                else {
                    Console.WriteLine("Please enter only number...");
                }

            } while (!isQuit);

            Console.WriteLine("Press any key....");
            Console.ReadLine();
        }

        static double Factorial(double number)
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
