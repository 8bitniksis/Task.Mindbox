using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    internal class Circle : FigureFactory
    {
        public double Radius { get; private set; }

        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            this.Radius = Radius;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
