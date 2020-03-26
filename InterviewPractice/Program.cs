using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    static class Program
    {
        static string Reverse(this string str)
        {
            str = str.Trim();
            string reverse = "";
            int space = str.Length - 1;

            for (int i = str.Length - 1; i > 0; i--)
            {
                int nextSpace = str.LastIndexOf(' ');
                string brokeStr = str.Substring(nextSpace + 1, space - nextSpace);
                string temp = "";

                for (int j = 1; j < brokeStr.Length + 1; j++)
                {
                    temp += brokeStr[brokeStr.Length - j];
                }

                reverse += temp + " ";

                if (nextSpace == -1)
                    break;

                space = str.LastIndexOf(' ') - 1;
                str = str.Remove(nextSpace);
            }

            return reverse;
        }

        static void CharCounter(this string str)
        {
            str = str.ToUpper();
            for (int i = 0; i < str.Length; i++)
            {
                int x = 1;

                if (str[i] != ' ')
                {
                    Console.Write($"{str[i]} - ");
                    for (int j = 1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            x++;
                            str = str.Remove(j, 1);
                            j--;
                        }
                    }

                    Console.WriteLine(x);
                }

                str = str.Remove(i, 1);
                i--;
            }
        }

        static void RemoveDuplicates(this string str)
        {
            string temp = str;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = i + 1; j < temp.Length; j++)
                {
                    if (temp[j] == temp[i])
                    {
                        temp = temp.Remove(j, 1);
                        j--;
                    }
                }
            }

            Console.WriteLine(temp);
        }

        static void AllPossibleSubstrings(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"{str[i]} ");

                for (int j = i; j < str.Length; j++)
                {
                    Console.Write(str[j]);
                }

                Console.Write(" ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string str = "Welcome to C# corner";

            Console.WriteLine(str.Reverse());
            str.CharCounter();

            str = "csharpcorner";
            str.RemoveDuplicates();

            str = "abcd";
            str.AllPossibleSubstrings();
        }
    }
}
