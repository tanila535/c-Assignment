using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.swap
{
    public class Swap
    {
        public static void Main(string[] args)
        {
            int a = 40, b = 30;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}


