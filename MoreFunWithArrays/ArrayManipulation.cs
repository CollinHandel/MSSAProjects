using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFunWithArrays
{
    public class ArrayManipulation
    {
        public static double Mean(int[] numbers)
        {
            double count = 0, sum = 0;
            foreach (var t in numbers)
            {
                count++;
                sum += t;
            }

            return (sum / count);
        }

        public static int[] Reversed(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var temp = numbers[(numbers.Length - 1) - i];
                numbers[(numbers.Length - 1) - i] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        public static int[] MoveItems(int[] numbers, string dir, int places)
        {
            int[] tempArray = new int[numbers.Length];

            if (dir == "left")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    tempArray[(i - (places % numbers.Length) < 0) ? ((places / numbers.Length) * numbers.Length) + (numbers.Length - 1) - (places - 1 - i) : (i - (places % numbers.Length))] =
                        numbers[i];
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    tempArray[(i + places > numbers.Length - 1) ? (i + places) % numbers.Length : i + places] =
                        numbers[i];
                }
            }

            return tempArray;
        }

        public static int[] Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
