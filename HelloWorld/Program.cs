using System;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ansArray = new int[5];
            string goodMsg = "Give me a random number from 1 to 10.";
            string badMsg = "That's not a number between 1 and 10.";
            for (int i = 0; i < ansArray.Length; i++)
            {
                Console.WriteLine(goodMsg);
                int answer = Int16.Parse(Console.ReadLine());
                while(answer > 10 || answer <= 0)
                {
                    Console.WriteLine(badMsg);
                    answer = Int16.Parse(Console.ReadLine());
                }
                ansArray[i] = answer;
            }
            Console.WriteLine(goodMsg);
            int final = Int16.Parse(Console.ReadLine());
            while(final > 10 || final <= 0)
            {
                Console.WriteLine(badMsg);
                final = Int16.Parse(Console.ReadLine());
            }
            int ansNum = final;

            int count = 0;

            foreach (int value in ansArray)
            {
                if (value == ansNum)
                    count++;
            }
            int score = count * ansNum;

            Console.WriteLine(score);
            Console.ReadLine();
        }
    }
}
