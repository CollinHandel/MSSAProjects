// Collin Handel
// 01/28/2020

using System;
using ClassLibrary;

namespace Lab3D
{
    class Program
    {
        static void Main()
        {
            try
            {
                char op;
                double x, y;
                MathApp mathApp = new MathApp();

                while (true)
                {
                    // CWL is a method for Console.WriteLine and CW is a method for Console.Write
                    CWL("----------------------");
                    CWL("Valid Math Operators:\n" +
                        " -   +   /   *   %");
                    CWL("----------------------");
                    CWL();



                    // User inputs  operator, if the user inputted a wrong operator, close the program.
                    CW("Input a operator: ");

                    if (!char.TryParse(Console.ReadLine(), out op) || !mathApp.CheckOperator(op)) break;
                    CWL();



                    // User inputs number 1 and checks if they're wanting to divide, to ensure it's not 0
                    do
                    {
                        CW($"Enter number 1 {(op == '/' ? "that is not 0" : "")}: ");
                    } while (!double.TryParse(Console.ReadLine(), out x) || mathApp.CheckDivide(op, x));  // Checks to see if dividing and if value is 0
                    CWL();



                    // User inputs number 1 and checks if they're wanting to divide, to ensure it's not 0
                    do
                    {
                        CW($"Enter number 2 {(op == '/' ? "that is not 0" : "")}: ");
                    } while (!double.TryParse(Console.ReadLine(), out y) || mathApp.CheckDivide(op, y));  // Checks to see if dividing and if value is 0
                    CWL();


                    // Perform and show the mathematical expression.
                    CWL(mathApp.Math(op, x, y));
                    CWL();
                }

                CWL();

                CWL("---------------------------\n" +
                    "| Thanks for stopping by! |\n" +
                    "---------------------------\n");

                Console.ReadKey();
            } 
            catch (DivideByZeroException ex)
            {
                CWL(ex.Message);
                Main();
            }
            catch (FormatException ex)
            {
                CWL(ex.Message);
                Main();
            }
            catch (Exception ex)
            {
                CWL(ex.Message);
                Main();
            }
        }

        static void CW(string line = "")
        {
            Console.Write(line);
        }

        static void CWL(string line = "")
        {
            Console.WriteLine(line);
        }
    }
}
