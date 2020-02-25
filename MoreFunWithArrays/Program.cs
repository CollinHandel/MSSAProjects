using System;

namespace MoreFunWithArrays
{
    class Program
    {
        static void Main()
        {
            int[] ArrayA, ArrayB, ArrayC;
            ArrayA = new[] {0, 2, 4, 6, 8, 10};
            ArrayB = new[] {1, 3, 5, 7, 9};
            ArrayC = new[] {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9};

            // Displaying Means
            Console.WriteLine("Mean of the Arrays:");
            Console.WriteLine($"The mean for ArrayA = {ArrayManipulation.Mean(ArrayA):#.##}");
            Console.WriteLine($"The mean for ArrayB = {ArrayManipulation.Mean(ArrayB):#.##}");
            Console.WriteLine($"The mean for ArrayC = {ArrayManipulation.Mean(ArrayC):#.##}");


            // Display Reversed Arrays
            Console.WriteLine("\nReversed Arrays:");
            ArrayA = ArrayManipulation.Reversed(ArrayA);
            ArrayB = ArrayManipulation.Reversed(ArrayB);
            ArrayC = ArrayManipulation.Reversed(ArrayC);
            for (int i = 0; i < ArrayA.Length; i++)
            {
                if (i != 0) Console.Write(", ");

                Console.Write(ArrayA[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < ArrayB.Length; i++)
            {
                if (i != 0) Console.Write(", ");

                Console.Write(ArrayB[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < ArrayC.Length; i++)
            {
                if (i != 0) Console.Write(", ");

                Console.Write(ArrayC[i]);
            }


            ArrayA = new[] { 0, 2, 4, 6, 8, 10 };
            ArrayB = new[] { 1, 3, 5, 7, 9 };
            ArrayC = new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            // Rotating Arrays
            Console.WriteLine("\n\nReordered Arrays:");
            ArrayA = ArrayManipulation.MoveItems(ArrayA, "left", 2);
            for (int i = 0; i < ArrayA.Length; i++)
            {
                if (i > 0) Console.Write(", ");

                Console.Write(ArrayA[i]);
            }
            Console.WriteLine();

            ArrayB = ArrayManipulation.MoveItems(ArrayB, "right", 2);
            for (int i = 0; i < ArrayB.Length; i++)
            {
                if (i > 0) Console.Write(", ");

                Console.Write(ArrayB[i]);
            }

            Console.WriteLine();

            ArrayC = ArrayManipulation.MoveItems(ArrayC, "left", 4);
            for (int i = 0; i < ArrayC.Length; i++)
            {
                if (i > 0) Console.Write(", ");

                Console.Write(ArrayC[i]);
            }


            // Sorting Arrays
            Console.WriteLine("\n\nSorting Arrays:");
            ArrayA = ArrayManipulation.Sort(ArrayA);
            for (int i = 0; i < ArrayA.Length; i++)
            {
                if (i != 0) Console.Write(", ");

                Console.Write(ArrayA[i]);
            }

            Console.WriteLine();

            ArrayB = ArrayManipulation.Sort(ArrayB);
            for (int i = 0; i < ArrayB.Length; i++)
            {
                if (i != 0) Console.Write(", ");

                Console.Write(ArrayB[i]);
            }

            Console.WriteLine();

            ArrayC = ArrayManipulation.Sort(ArrayC);
            for (int i = 0; i < ArrayC.Length; i++)
            {
                if (i != 0) Console.Write(", ");

                Console.Write(ArrayC[i]);
            }

            Console.WriteLine();
        }
    }
}
