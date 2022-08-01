using System;

namespace GuessingGame_ConsoleApp
{
    internal class Program
    {
        static public int rInt;
        static public int numAnswer;

        static void Main(string[] args)
        {
            Random r = new Random();
            rInt = r.Next(1, 100);
            Console.WriteLine("Guess what number I am thinking of! Its between 1 and 100");
            Check();
        }

        static private void Check()
        {

            string answer = Console.ReadLine();
            answer = answer.Trim();
            bool isNumeric = int.TryParse(answer, out _);
            if (isNumeric)
            {
                numAnswer = Int32.Parse(answer);
            }
            else
            {
                Console.WriteLine("That is not a number...");
                Check();
            }

            if(numAnswer > 0 && numAnswer < 101)
            {
                Play(numAnswer);
            }
            else
            {
                Console.WriteLine("The number must be above zero and below 101.");
                Check();
            }

        }

        static private void Play(int answer)
        {
            if(answer > rInt)
            {
                Console.WriteLine("The number I am thinking of is lower. Try again.");
            }
            else if(answer < rInt)
            {
                Console.WriteLine("The number I am thinking of is higher. Try again.");
            }
            else
            {
                Console.WriteLine(rInt.ToString()+" is correct!");
                End();
            }
            Check();
        }

        static int End()
        {
            return 0;
        }

    }
}
