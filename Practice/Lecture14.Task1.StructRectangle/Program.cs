using System;

namespace Lecture14.Task1.StructRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[100];

            Random random = new Random();
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].height = random.Next(1, 10);
                rectangles[i].width = random.Next(1, 10);
            }

            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"height: {rectangles[i].height} x width: {rectangles[i].width}");
            }

            int sum = 0;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].height.Equals(rectangles[0].height) && rectangles[i].width.Equals(rectangles[0].width))
                    sum += 1;
            }

            Console.WriteLine($"Duplicates: {sum}");
        }
    }
}
