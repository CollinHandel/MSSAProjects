using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MathApp
    {
        public string Math(char op, double x, double y)
        {
            switch (op)
            {
                case '+':
                    return Add(x, y);
                case '-':
                    return Sub(x, y);
                case '*':
                    return Mult(x, y);
                case '/':
                    return Divide(x, y);
                default:
                    return Mod(x, y);
            }
        }

        public bool CheckOperator(char op)
        {
            char[] operators = new char[5] { '+', '-', '*', '/', '%' };

            foreach (char ops in operators)
            {
                if (ops == op)
                {
                    return true;
                }
            }

            return false;

        }

        private string Add(double x, double y) => $"{x} + {y} = {x + y}"; 
        private string Divide(double x, double y) => $"{x} / {y} = {x / y}";
        private string Mult(double x, double y) => $"{x} * {y} = {x * y}";
        private string Sub(double x, double y) => $"{x} - {y} = {x - y}";
        private string Mod(double x, double y) => $"{x} % {y} = {x % y}";

        public bool CheckDivide(char op, double x) => x == 0 && op == '/' ? true : false;
    }
}
