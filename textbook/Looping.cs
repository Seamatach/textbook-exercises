/* This cs page is on loops. There are again several small projects that focus on using looping as a key logic component of the program.
 * The navigation is using a switch statement to know which exercise to run.
 * 
 * 
 */

using System;

namespace textbook
{
    class Looping
    {
        public static void index()
        {
            Console.WriteLine("Welcome to the chapter on looping.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to:");
            Console.WriteLine("Adding Doubles");
            Console.WriteLine("Rock Paper Scissors");
            Console.WriteLine("Lottery");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "adding doubles":
                    AddingDoubles();
                    break;
                //case "rock paper scissors":
                //    RockPaperScissors();
                //    break;
                //case "lottery":
                //    Lottery();
                //    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                    break;
            }
        }

        public static void AddingDoubles()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                double total = 0;
                const int loop = 5;

                Console.WriteLine("Enter five numbers you want to sum together.");
                double i = 0;
                while (i < loop)
                {
                    Console.WriteLine("Please enter the number to add to the total.");
                    double input = Convert.ToDouble(Console.ReadLine());
                    total = total + input;
                    i++;
                }

                Console.WriteLine("Your total is : {0}.", total);
                Console.WriteLine("Do you have more numbers to add together? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static void CheckLower()
        {
            char input;

            Console.WriteLine("Enter a letter please.");
            Console.WriteLine("If its a lower case letter, you will receive an OK!");
            input = Convert.ToChar(Console.ReadKey());
            while (input != '!')
            {
                while (char.IsLower(input) == false)
                {
                    while (char.IsLower(input) == true)
                    {
                        Console.WriteLine("OK");
                        CheckLower() ;
                    }
                }
                break;
            }
        }
    }
}
