using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctGuess = false;

            do
            {
                Console.Write("Guess a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed " + number + "!");
                        break;
                    case 29:
                        Console.WriteLine("You guessed " + number + "!");
                        break;
                    case 55:
                        Console.WriteLine("You guessed " + number + "!");
                        break;
                    case 12:
                        Console.WriteLine("You guessed " + number + "!  That is correct!");
                        correctGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong!");
                        break;
                }
            }
            while (!correctGuess);

            Console.WriteLine("\nThis is the end of the program");
            Console.Read();
        }
    }
}
