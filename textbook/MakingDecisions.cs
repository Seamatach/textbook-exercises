/* This cs page is on making simple decisions in c# using if else and switch statements.
 * In line documentation is presented before the method and where it will be relevant.
 * Each exercise using a simple while loop to run the game again, and if else statements for the games logic.
 */

using System;
using System.Diagnostics;

namespace textbook
{
    class MakingDecisions
    {
        /// <summary>
        /// This is the class specific main function for my programs. They are simple switch statements to direct the user to the right mini program.
        /// </summary>
        public static void index()
        {
            Console.WriteLine("Welcome to the chapter on making decisions.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to:");
            Console.WriteLine("Number Guessing");
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("Lottery");

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
                case "lottery":
                    Lottery();
                    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                   break;

                    // Need to add an exit option here and at all menus in all classes.
            }
        }

        /// <summary>
        /// This is a simple game of guess the number. I have a while loop to allow multiple games and a simple if else-if else statement as the logic of the game.
        /// </summary>
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

        /// <summary>
        /// This is a game of Rock, Paper, Scissors. I have a while loop to allow multiple games and nested else if statements as the logic of the game.
        /// </summary>
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

        /// <summary>
        /// This is a Lottery game. I have a while loop to allow multiple games and a set of if statements to evaluate the guesses to the randoms, and an else if statement to determine prizes.
        /// </summary>
        public static void Lottery()
        {
            bool keepPlaying = true;
            int winnings = 0;

            while (keepPlaying)
            {
                Random random = new Random();
                int lottery1 = random.Next(4) + 1;
                int lottery2 = random.Next(4) + 1;
                int lottery3 = random.Next(4) + 1;
                int userGuess1;
                int userGuess2;
                int userGuess3;
                int numOfWins = 0;
                int money = 0;

                Console.WriteLine("Welcome to the Lottery Game.");
                Console.WriteLine("Rules of the Lottery Game:");
                Console.WriteLine("The computer guesses 3 random numbers between 1 and 4.");
                Console.WriteLine("The player will attempt to guess the three numbers.");
                Console.WriteLine("After all the guesses have been completed the computer will evaluate the guesses.");
                Console.WriteLine("The scoring is evaluated as follows:");
                Console.WriteLine("No matches = $0");
                Console.WriteLine("Any one match = $10");
                Console.WriteLine("Any two matching = $100");
                Console.WriteLine("Three matching but not in the same order = $1,000");
                Console.WriteLine("All three matching in order = $10,000");

                Console.WriteLine("What is your first guess?");
                userGuess1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your second guess?");
                userGuess2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your third guess?");
                userGuess3 = Convert.ToInt32(Console.ReadLine());

                if (lottery1 == userGuess1 || lottery1 == userGuess2 || lottery1 == userGuess3)
                {
                    numOfWins++;
                }
                if (lottery2 == userGuess1 || lottery2 == userGuess2 || lottery2 == userGuess3)
                {
                    numOfWins++;
                }
                if (lottery3 == userGuess1 || lottery3 == userGuess2 || lottery3 == userGuess3)
                {
                    numOfWins++;
                }
                if (lottery1 == userGuess1 && lottery2 == userGuess2 && lottery3 == userGuess3 )
                {
                    numOfWins++;
                }

                if (numOfWins == 1)
                {
                    Console.WriteLine("Congrats! You picked a match. You won $10.");
                    money = money + 10;
                }
                else if (numOfWins == 2)
                {
                    Console.WriteLine("Congrats! You picked two matches. You won $100.");
                    money = money + 100;
                }
                else if (numOfWins == 3)
                {
                    Console.WriteLine("Congrats! You picked three matches. You won $1,000.");
                    money = money + 1000;
                }
                else if (numOfWins == 4)
                {
                    Console.WriteLine("Congrats! You picked three matches. You won $10,000.");
                    money = money + 10000;
                }
                else
                {
                    Console.WriteLine("I'm sorry. You didn't get any matches. You didn't win anything.");
                }
                winnings = winnings + money;
                Console.WriteLine("Your winning total is ${0}.", winnings);
                Console.WriteLine("New game? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }
    }
}
