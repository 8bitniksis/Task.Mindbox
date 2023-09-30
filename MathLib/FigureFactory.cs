using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public abstract class FigureFactory
    {
        internal string FigureName { get; private set; }

        public FigureFactory(string FigureName)
        {
            this.FigureName = FigureName;
        }

        public abstract double CalcSquare();
    }
}
