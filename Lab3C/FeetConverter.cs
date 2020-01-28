using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C
{
    class FeetConverter
    {
        public void Feet()
        {
            double feet;
            string temp;
            do
            {
                Console.Write("Input the amount of feet to convert above 0: ");
                temp = Console.ReadLine();
            } while (!double.TryParse(temp, out feet) || feet <= 0);

            Console.WriteLine($"\n{feet} feet is {FeetToInches(feet)} inches.");
        }

        private static double FeetToInches(double feet)
        {
            return feet * 12;
        }
    }
}
