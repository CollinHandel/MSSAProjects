using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuition();
            Console.Write("\n\n");

            FeetConverter feet = new FeetConverter();
            feet.Feet();

            Console.Write("\n\n");

            Greater greater = new Greater();
            greater.Calling();

            Console.ReadKey();
        }

        static void Tuition()
        {
            double tuition = 6000;
            
            for (int i = 1; i <= 5; i++)
            {
                tuition += (tuition * .02);
                Console.WriteLine($"For year {i}, your tuition will be {tuition.ToString("c")}.");
            }
        }
    }
}
