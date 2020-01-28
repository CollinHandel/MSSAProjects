using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2ACollin
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
            Console.ReadLine();
        }

        void run() {
            Console.Write("Sum of Scores");
            sumOfNumbers();
            Console.WriteLine();

            Console.Write("Average of Ten Numbers");
            averageTenNumbers();
            Console.WriteLine();

            Console.Write("Average of Specific Numbers");
            averageSpecificNumbers();
            Console.WriteLine();

            Console.Write("Average of Non Specific Numbers");
            averageNonSpecificNumbers();
        }

        private void sumOfNumbers()
        {
            Console.WriteLine($"The sum of all 10 numbers is: {scoresSum()}");
        }

        private void averageTenNumbers()
        {
            int average = scoresSum() / 10;

            Console.WriteLine($"The average letter grade is: {letterGrade(average)}");
        }

        private void averageSpecificNumbers()
        {
            Console.WriteLine("Enter the amount of tests to enter: ");
            int.TryParse(Console.ReadLine(), out int numTests);

            int average = scoresSum(numTests) / numTests;

            Console.WriteLine($"The average letter grade is: {letterGrade(average)}");
        }

        private void averageNonSpecificNumbers()
        {
            int total = 0, count = 0;
            string input;
            do
            {
                Console.WriteLine("Enter test score or type n to complete:");

                input = Console.ReadLine();

                int value;
                if (int.TryParse(input, out value))
                {
                    if (value >= 0 && value <= 100)
                    {
                        total += value;
                        count++;
                    }
                }
            } while (input != "n");
            
            int average = total / count;

            Console.WriteLine($"The average letter grade is: {letterGrade(average)}");
        }

        private int scoresSum(int numTests = 10)
        {
            int tempNum = 0, sum = 0;

            for (int i = 0; i < numTests; i++)
            {
                do
                {
                    Console.Write($"Enter score {i + 1}: ");
                    Int32.TryParse(Console.ReadLine(), out tempNum);
                } while (tempNum < 0 || tempNum > 100);

                sum += tempNum;
            }

            return sum;
        }

        private string letterGrade(int avgGrade)
        {
            if (avgGrade >= 97) return "A+";
            else if (avgGrade >= 93) return "A";
            else if (avgGrade >= 90) return "A-";
            else if (avgGrade >= 87) return "B+";
            else if (avgGrade >= 83) return "B";
            else if (avgGrade >= 80) return "B-";
            else if (avgGrade >= 77) return "C+";
            else if (avgGrade >= 73) return "C";
            else if (avgGrade >= 70) return "C-";
            else if (avgGrade >= 67) return "D+";
            else if (avgGrade >= 63) return "D";
            else if (avgGrade >= 60) return "D-";
            else return "F";
        }
    }
}
