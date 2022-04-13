using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class AreaCalcutor
    {
        public double Calc(Shape[] shapes)
        {
            double sum = 0;
            foreach (var item in shapes)
            {
                sum += item.CalcArea();
            }

            return sum;
        }
    }
}
