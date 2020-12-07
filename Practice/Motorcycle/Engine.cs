using System;
using System.Collections.Generic;
using System.Text;

namespace Motorcycle
{
    class Engine
    {
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 125 && value <= 3_200)
                    _volume = value;
                else
                {
                    Console.WriteLine("Enter 125 - 3200.");
                    return;
                }
            }
        }

        private int _power;

        public int Power
        {
            get { return _power; }
            set 
            {
                if (value >= 50 && value <= 300)
                    _power = value;
                else
                {
                    Console.WriteLine("Enter 50 - 300.");
                    return;
                }
            }
        }
    }
}
