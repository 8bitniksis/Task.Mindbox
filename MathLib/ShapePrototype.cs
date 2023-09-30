using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    internal static class ShapePrototype
    {
        internal static double CalcSquare(FigureFactory shape) => shape.CalcSquare();
    }
}
