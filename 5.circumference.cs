using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.circumference
{
    class Circle
    {

        float _PI = 3.14F;
        int _Radius;
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return this._PI * this._Radius * this._Radius;
        }
        public float CalculateCircumference()
        {
            return 2 * this._PI * this._Radius;
        }
    }
    class Program
    {
        public static void Main()
        {
            Circle C1 = new Circle(6);
            {
                float Area = C1.CalculateArea();
                Console.WriteLine("Area={0}", Area);
            }
            {

                float Circumference = C1.CalculateCircumference();
                Console.WriteLine("Circumference={0}", Circumference);
            }

        }

    }
}
    

