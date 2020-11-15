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
            if (now.Hours >= 9 && now.Hours < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (now.Hours >= 12 && now.Hours < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (now.Hours >= 15 && now.Hours < 22)
            {
                Console.WriteLine("Good day, guys");
            }
            else
                Console.WriteLine("Good night, guys");
        }
    }
}
