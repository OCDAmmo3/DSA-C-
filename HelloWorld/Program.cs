using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Score()
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

            // Score();

            static void LeapYear()
            {
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
            }

            // LeapYear();

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

            int[] numsBad = new int[] { 1, 2, 3, 4, 5 };
            int[] numsGood = new int[] { 1, 2, 3 };

            // Console.WriteLine(Perfect(numsBad));
            // Console.WriteLine(Perfect(numsGood));

            static void SumRows(int[,] values)
            {
                int val1 = values.GetLength(0);
                int val2 = values.GetLength(1);
                int[] result = new int[val1];
                string answer = "";
                for(int i = 0; i < val1; i++)
                {
                    int count = 0;
                    for(int j = 0; j < val2; j++)
                    {
                        count += values[i, j];
                    }
                    result[i] = count;
                    answer = answer == "" ? answer + count : answer + ", " + count;
                }
                Console.WriteLine(answer);
                Console.ReadLine();
            }

            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };

            Console.WriteLine("We expect our function will take in an array of values [[1,2,3,4,5],[6,7,8,9,10],[11,12,13,14,15]] and return the values 15,40,65 in that order, the sums of each inner array.");
            Console.ReadLine();
            SumRows(myArray);

            Console.WriteLine("What values would you like added together? Give us how many arrays you want. 1 to 5 please.");
            int user1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("And how many values in each array? This can be 1-10");
            int user2 = Int16.Parse(Console.ReadLine());

            int[,] userArray = new int[user1, user2];

            for(int i = 0; i < user1; i++)
            {
                for(int j = 0; j < user2; j++)
                {
                    userArray[i, j] = (user2 * i) + j + 1;
                }
            }

            SumRows(userArray);
        }
    }
}
