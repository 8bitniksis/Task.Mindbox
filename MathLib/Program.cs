using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle", 12);
            Triangle triangle = new Triangle("Triangle", 4, 4, 5);

            Console.WriteLine(circle.CalcSquare());
            Console.WriteLine(triangle.CalcSquare());
        }
    }
}
