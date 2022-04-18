using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            string operand;
            float number;
            Console.WriteLine("enter first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an operand(+,-,/,*):");
            operand = Console.ReadLine();

            switch(operand)
            {
                case "+":
                    number = n1 + n2;
                    break;
                case "-":
                    number = n1 - n2;
                    break;
                case "/":
                    number = n1 / n2;
                    break;
                case "*":    
                    number = n1 * n2;
                    break;
                default:
                    number = 0;
                    break;

            }
            Console.WriteLine(n1.ToString() + " " + operand + "" + n2.ToString() + "=" + number.ToString());
            Console.ReadLine();

        }
    }
}
