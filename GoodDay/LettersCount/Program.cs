using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string userInput = Console.ReadLine();
            char[] userInputs = userInput.ToCharArray();
            
            int sumA = 0;
            for (int i = 0; i < userInputs.Length; i++)
            {
                if (userInputs[i] == 'a' || userInputs[i] == 'A')
                    sumA++;
            }

            Console.WriteLine($"Your word count {sumA} letters A");
        }
    }
}
