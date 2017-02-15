using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace textbook
{
    class MakingDecisions
    {
        public static void index()
        {
            Console.WriteLine("Welcome to the Chapter on Making Decisions.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to ");
            Console.WriteLine("Number Guessing");
            Console.WriteLine("Rock Paper Scissors");
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
                case "rock paper scissors":
                    RockPaperScissors();
                    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                   break;
            }
        }

        public static void NumberGuess()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Random ranNumberGenerator = new Random();
                int randomNumber;
                int min = 1;
                int max = 10;
                int guess;
                randomNumber = ranNumberGenerator.Next(min, max);
                Console.WriteLine("Guess a number between 1 and 10.");
                Console.WriteLine("You only get one guess, so make it count.");
                guess = Convert.ToInt16(Console.ReadLine());

                if (guess < randomNumber)
                    Console.WriteLine("Your guess is too low.");
                else if (guess == randomNumber)
                    Console.WriteLine("You guessed correctly.");
                else if (guess > randomNumber)
                    Console.WriteLine("Your guess is too high.");
                else
                    Console.WriteLine("Your guess is not a legal number in this game.");

                if (Debugger.IsAttached)
                {
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadLine();
                }
                Console.WriteLine("New game? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static void RockPaperScissors()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Random random = new Random();
                int compGuess = random.Next(4);
                Console.WriteLine("Welcome to Rock Paper Scissors.");
                Console.WriteLine("Rules of the game:");
                Console.WriteLine("Both players choose one of the three options at the same time.");
                Console.WriteLine("If both players select the same thing the game is a tie.");
                Console.WriteLine("Otherwise the winner is determined by the following rules:");
                Console.WriteLine("Rock beats scissors");
                Console.WriteLine("Scissors beats paper");
                Console.WriteLine("Paper beats rock");

                Console.WriteLine("What is your choice? Rock Paper or Scissors?");
                string userGuess = Console.ReadLine();
                userGuess = userGuess.ToLower();
                if (compGuess == 1)
                {
                    if (userGuess == "rock")
                    {
                        Console.WriteLine("The computer choose rock.");
                        Console.WriteLine("This game is a tie.");
                    }
                    else if (userGuess == "paper")
                    {
                        Console.WriteLine("The computer choose rock.");
                        Console.WriteLine("This game is a tie.");
                    }
                    else if (userGuess == "scissors")
                    {
                        Console.WriteLine("The computer choose scissors.");
                        Console.WriteLine("This game is a tie.");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");
                    }
                }
                else if (compGuess == 2)
                {
                    if (userGuess == "rock")
                    {
                        Console.WriteLine("The computer choose paper.");
                        Console.WriteLine("Sorry, you lose this game. Paper wraps rock.");
                    }
                    else if (userGuess == "paper")
                    {
                        Console.WriteLine("The computer choose scissors.");
                        Console.WriteLine("Sorry, you lose this game. Scissors cuts paper.");
                    }
                    else if (userGuess == "scissors")
                    {
                        Console.WriteLine("The computer choose rock.");
                        Console.WriteLine("Sorry, you lose this game. Rock smashes scissors.");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");
                    }
                }
                else if (compGuess == 3)
                {
                    if (userGuess == "rock")
                    {
                        Console.WriteLine("The computer choose scissors.");
                        Console.WriteLine("Congrats! You won this game. Rock smashes scissors.");
                    }
                    else if (userGuess == "paper")
                    {
                        Console.WriteLine("The computer choose paper.");
                        Console.WriteLine("Congrats! You won this game. Scissors cut paper.");
                    }
                    else if (userGuess == "scissors")
                    {
                        Console.WriteLine("The computer choose rock.");
                        Console.WriteLine("Congrats! You won this game. Paper wraps rock.");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");
                    }
                }
                Console.WriteLine("New game? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }
    }
}
