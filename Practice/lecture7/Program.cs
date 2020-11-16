using System;

namespace lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();
            SumArray();
            MaxValue();

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

            static void MaxValue()
            {
                int[] nums = new int[13];
                Random random = new Random();

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = random.Next(0, 100);
                }

                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }

                Array.Sort(nums);
                Console.WriteLine($"Max value: {nums[nums.Length - 1]}");
            }
        }
    }
}
