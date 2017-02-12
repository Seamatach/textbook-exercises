using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbook
{
    class MakingDecisions
    {
        public static void main()
        {
            Console.WriteLine("Welcome to the Chapter on Making Decisions.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to ");
            Console.WriteLine("Number Guessing");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "number guessing":
                    NumberGuess();
                    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                   break;
            }
        }

        public static void NumberGuess()
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            int min = 1;
            int max = 10;
            int guess;
            randomNumber = ranNumberGenerator.Next(min, max);
            Console.WriteLine("There is only one rule: Guess a number between 1 and 10.");
            guess = Convert.ToInt16(Console.ReadLine());

            if (guess < randomNumber)
                Console.WriteLine("Your guess is too low.");
            else if (guess == randomNumber)
                Console.WriteLine("You guessed correctly.");
            else if (guess > randomNumber)
                Console.WriteLine("Your guess is too high.");
            else
                Console.WriteLine("Your guess is not a legal number in this game.");
        }
    }
}
