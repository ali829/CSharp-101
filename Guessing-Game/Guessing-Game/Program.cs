using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "tiger";
            string guess = "";
            int guessLimit = 3;
            int guessCount = 0;
            bool outOfGuesses = false;


            while (guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Guess the word :");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (!outOfGuesses)
            {
                Console.WriteLine("You Win !!");
            }
            else
            {
                Console.WriteLine("You Lost !!");
            }


            Console.ReadLine();
        }
    }
}
