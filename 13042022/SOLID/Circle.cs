using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class Circle: Shape
    {
        public double Radius;
        public override double CalcArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
