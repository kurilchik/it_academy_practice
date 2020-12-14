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
        }
    }
}
