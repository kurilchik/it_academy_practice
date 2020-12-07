using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Figures
{
    class Triangle : IFigure
    {
        public int Value { get; set; }

        public double Area { get; set; }

        public void AreaCalc()
        {
            double h = Math.Sqrt(Math.Pow(Value, 2) - Math.Pow(Value, 2) / 4);
            Area = (Value * h) / 2;
        }
    }
}
