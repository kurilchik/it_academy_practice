using System;

namespace Lecture15.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem uniqueItem = new UniqueItem();
            Console.WriteLine(uniqueItem.Id);

            UniqueItem uniqueItem2 = new UniqueItem();
            Console.WriteLine(uniqueItem2.Id);

            UniqueItem uniqueItem3 = new UniqueItem(10);
            Console.WriteLine(uniqueItem3.Id);

            UniqueItem uniqueItem4 = new UniqueItem();
            Console.WriteLine(uniqueItem4.Id);
        }
    }
}
