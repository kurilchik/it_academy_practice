using System;

namespace lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();
            SumArray();

            static void EmptyArray()
            {
                int length = 0;
                object[] emptyArray = new object[length];
            }

            static void SumArray()
            {
                object[] sumArray = new object[3] { 32, 'A', "Hello" };
                foreach (var item in sumArray)
                {
                    Console.WriteLine(item);
                }

                sumArray[0] = (int)sumArray[0] + 10;
                sumArray[2] = (string)sumArray[2] + ", guys!";
                foreach (var item in sumArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
