using System;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

            Console.WriteLine("Give me a random year in format YYYY: ");
            string not = "It's not a leap year.";
            string yes = "It's indeed a leap year!";
            int input = Int16.Parse(Console.ReadLine());
            if(input % 4 == 0)
            {
                if(input % 100 == 0 && input % 400 != 0)
                {
                    Console.WriteLine(not);
                }
                else
                {
                    Console.WriteLine(yes);
                }
            }
            else
                Console.WriteLine(not);
            Console.ReadLine();
            */

            int[] numsBad = new int[] { 1, 2, 3, 4, 5 };
            int[] numsGood = new int[] { 1, 2, 3 };

            static string Perfect(int[] array)
            {
                int product = 1;
                int sum = 0;
                foreach(int value in array)
                {
                    if (value < 0)
                        return "No";
                    product *= value;
                    sum += value;
                }
                if(sum == product)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }

            Console.WriteLine(Perfect(numsBad));
            Console.WriteLine(Perfect(numsGood));
        }
    }
}
