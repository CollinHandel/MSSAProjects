using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_Mathematical_Formulations
{
    class Program
    {
        static void Main()
        {
            try {
                int selected = 0;

                Console.WriteLine();

                do
                {
                    Console.WriteLine("Input:\n" +
                        "1 - Circumference\n" +
                        "2 - Hemisphere\n" +
                        "3 - Triangle\n" +
                        "4 - Quadratic Equation\n" +
                        "or input 0 to quit.");
                } while (!int.TryParse(Console.ReadLine(), out selected) || selected < 0 || selected > 4);

                Console.WriteLine();

                switch (selected)
                {
                    case 1:
                        Circumference();
                        break;
                    case 2:
                        Hemisphere();
                        break;
                    case 3:
                        AreaTriangle();
                        break;
                    case 4:
                        QuadraticEquation();
                        break;
                }
            
            } catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main();
            }
            finally
            {
                Console.WriteLine("The program has finally terminated.");
            }

            Console.ReadKey();

        }
        
        static void Circumference()
        {
            double area, r;

            do
            {
                Console.WriteLine("Enter a positive number for the Circle Radius:");
                r = checked(double.Parse(Console.ReadLine()));
            } while (r <= 0);

            double circ;
            checked
            {
                circ = 2 * Math.PI * r;
                area = checked(Math.PI * Math.Pow(r, 2));
            }
            Console.WriteLine($"Circle: \t Radius: {r.ToString()} --- Circumference: {circ.ToString()} --- Area: {area.ToString()}");

            Main();
        }

        static void Hemisphere()
        {
            double r;

            do
            {
                Console.WriteLine("Enter a positive number for the Hemisphere Radius:");
                r = checked(double.Parse(Console.ReadLine()));
            } while (r <= 0);
            double volume = checked(((4 / 3) * Math.PI * Math.Pow(r, 3)) / 2);
            Console.WriteLine($"Hemisphere: \t Radius: {r.ToString()} --- Volume: {volume.ToString()}");

            Main();
        }

        static void AreaTriangle()
        {
            double area;
            int a, b, c;

            do
            {
                Console.WriteLine("Enter the length of Side A of the Triangle:");
                a = checked(int.Parse(Console.ReadLine()));
            } while (a <= 0);

            do
            {
                Console.WriteLine("Enter the length of Side B of the Triangle:");
                b = checked(int.Parse(Console.ReadLine()));
            } while (b <= 0);

            do
            {
                Console.WriteLine("Enter the length of Side C of the Triangle:");
                c = checked(int.Parse(Console.ReadLine()));
            } while (c <= 0);

            double p = (a + b + c) / 2;
            area = checked(Math.Sqrt(((p * (p - a)) * (p - b) * (p - c))));
            Console.WriteLine($"Triangle: \t Half Circumference: {p.ToString()} --- Area: {area.ToString()}");

            Main();
        }

        static void QuadraticEquation()
        {
            int a, b, c;

            do
            {
                Console.WriteLine("Enter the value of Coefficient A:");
                a = checked(int.Parse(Console.ReadLine()));
            } while (a <= 0);

            do
            {
                Console.WriteLine("Enter the value of Coefficient B:");
                b = checked(int.Parse(Console.ReadLine()));
            } while (b <= 0);

            do
            {
                Console.WriteLine("Enter the value of Coefficient C:");
                c = checked(int.Parse(Console.ReadLine()));
            } while (c <= 0);

            double identifier = b * b - (4 * a * c);

            identifier = identifier < 0 ? identifier * -1 : identifier;

            double posX = checked((-b + Math.Sqrt(identifier)) / (2 * a));
            double negX = checked((-b - Math.Sqrt(identifier)) / (2 * a));

            Console.WriteLine($"Quadratic Formula: \t Positive: {posX.ToString()} --- Negative: {negX.ToString()}");

            Main();
        }
    }
}












