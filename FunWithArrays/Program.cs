using System;

namespace FunWithArrays
{
    class Program
    {
        static void Main()
        {
            // Display the array
            int[] numbers = { 9, 10, 12, 12, 23, 10, 12, 14, 16, 9, 11, 3, 14, 23, 24, 3, 3 };
            Console.WriteLine("Array in Original Order:");
            foreach (var num in numbers)
            {
                if (Array.IndexOf(numbers, num) != 0)
                    Console.Write(", ");

                Console.Write($"{num}");
            }

            // Sort an array in an ascending order
            Console.WriteLine("\n\nArray in Ascending Order:");

            foreach (var num in AscendingNumbers(numbers))
            {
                if (Array.IndexOf(numbers, num) != 0)
                    Console.Write(", ");

                Console.Write($"{num}");
            }

            // Reverse the order of an array
            numbers = new[] { 9, 7, 3, 12, 1 };
            Console.WriteLine("\nArray in Reverse Order:");
            foreach (var num in ReverseNumbers(numbers))
            {
                if (Array.IndexOf(numbers, num) != 0)
                    Console.Write(", ");

                Console.Write($"{num}");
            }


            // Remove Duplicates from number array
            Console.WriteLine("\n\nRemove duplicates:");
            numbers = new[] {9, 10, 12, 12, 23, 10, 12, 14, 16, 9, 11, 3, 14, 23, 24, 3, 3};
            
            foreach (var num in RemoveDuplicates(numbers))
            {
                if (Array.IndexOf(numbers, num) != 0)
                    Console.Write(", ");

                Console.Write($"{num}");
            }


            // Palindrome
            string str = "Do Geese See God";
            Console.WriteLine($"\n\nIs string \"{str}\" a palindrome?: {IsPalindrome(str)}");

            Console.WriteLine("\n\n");
        }

        static int[] AscendingNumbers(int[] numbers)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    if (numbers[y] > numbers[x])
                    {
                        var temp = numbers[y];
                        numbers[y] = numbers[x];
                        numbers[x] = temp;
                    }
                }
            }

            return numbers;
        }

        static int[] ReverseNumbers(int[] numbers)
        {
            // Reverse order of numbers 
            for (int i = 0; i < (numbers.Length - 1) / 2; i++)
            {
                var temp = numbers[(numbers.Length - 1) - i];
                numbers[(numbers.Length - 1) - i] = numbers[i];
                numbers[i] = temp;
            }

            return numbers;
        }

        static int[] RemoveDuplicates(int[] numbers)
        {
            // Sorting
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    if (numbers[x] > numbers[i])
                    {
                        var temp = numbers[x];
                        numbers[x] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            // Counting the amount of duplicates
            int duplicates = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    duplicates++;
                }
            }

            // Putting unique values into new array
            int[] newNumbers = new int[numbers.Length - duplicates];
            int count = 0;
            foreach (var t in numbers)
            {
                if (count == 0 || newNumbers[count - 1] != t)
                {
                    newNumbers[count] = t;
                    count++;
                }
            }

            return newNumbers;
        }

        static bool IsPalindrome(string str)
        {
            str = str.ToLower().Replace(" ", "");

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
