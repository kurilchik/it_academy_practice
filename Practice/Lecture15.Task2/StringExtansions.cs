using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Task2
{
    public static class StringExtansions
    {
        public static string ShortString(this string str)
        {
            string result = str.Remove(5);
            result = result + "...";
            return result;
        }
    }
}
