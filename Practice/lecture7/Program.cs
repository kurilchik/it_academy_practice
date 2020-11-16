using System;

namespace lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();

            static void EmptyArray()
            {
                int length = 0;
                object[] emptyArray = new object[length];
            }
        }
    }
}
