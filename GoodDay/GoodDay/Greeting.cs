using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDay
{
    class Greeting
    {
        public static void Time()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now.Hours >= 9 || now.Hours < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
        }
    }
}
