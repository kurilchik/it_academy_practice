using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Figures
{
    class Circle : IFigure
    {
        public int Value { get ; set ; }

        public double Area { get; set; }

        public void AreaCalc()
        {
            Area = Math.PI * Math.Pow(Value, 2);
        }
    }
}
