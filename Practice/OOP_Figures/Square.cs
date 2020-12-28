using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Figures
{
    class Square : IFigure
    {
        public int Value  { get ; set ; }

        public double Area { get; set; }

        public void AreaCalc()
        {
            Area = Math.Pow(Value, 2);
        }
    }
}
