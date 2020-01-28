using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3C
{
    class Greater
    {
        public void Calling()
        {
            int x, y;
            string temp;

            do
            {
                Console.Write("Input number 1: ");
                temp = Console.ReadLine();
            } while (!int.TryParse(temp, out x));

            do
            {
                Console.Write("Input number 2: ");
                temp = Console.ReadLine();
            } while (!int.TryParse(temp, out y));

            if (x == y)
                Console.WriteLine($"{x} is equal to {y}");
            else
                Console.WriteLine($"\n{Max(x, y)} is great than {Min(x, y)}.");
        }

        private static int Max(int x, int y)
        {
            return Math.Max(x, y);
        }

        private static int Min(int x, int y)
        {
            return Math.Min(x, y);
        }
    }
}
