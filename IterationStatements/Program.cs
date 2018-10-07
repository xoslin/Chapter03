using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            string password = string.Empty;
            int counter = 0;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                counter++;
                if (password != "secret")
                {
                    WriteLine("Wrong password");
                }            
            }
            while (password != "secret" && counter < 10);

            if (password=="secret" && counter < 10)
            {
                WriteLine("Correct!");
            }
            else
            {
                WriteLine("You exceeded the number of attempts.");
            }

            for (int y = 0; y <= 10; y++)
            {
                WriteLine(y);
            }
            ReadKey();
        }
    }
}
