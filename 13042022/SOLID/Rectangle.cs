using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class Rectangle: Shape
    {
        public int Width;
        public int Height;

        public override double CalcArea()
        {
            return Width * Height;
        }
    }
}
