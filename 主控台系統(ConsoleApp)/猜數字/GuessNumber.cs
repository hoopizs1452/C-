using System;

namespace ConsoleApp1
{
    class GuessNumber
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(0, 100);
            bool win = false;
            do
            {
                Console.Write("Enter a number between 0 and 100:");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i > x)
                    Console.WriteLine("To Higher, Guess Lower...");
                else if (i < x)
                    Console.WriteLine("To Lower, Guess Higher...");
                else if(i == x)
                {
                    Console.WriteLine("You win!!");
                    win = true;
                }
            } while (win == false);
            Console.WriteLine();
        }
    }
}
