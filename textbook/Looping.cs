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
            Console.WriteLine("Check Lower");
            //Console.WriteLine("Lottery");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "adding doubles":
                    AddingDoubles();
                    break;
                case "check lower":
                    CheckLower();
                    break;
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
            bool keepGoing = true;
            while (keepGoing)
            {
                string input;

                Console.WriteLine("Enter a letter please.");
                Console.WriteLine("If its a lower case letter, you will receive an OK!");
                input = Console.ReadLine();
                char verify = Convert.ToChar(input);
                while (char.IsLower(verify) == true)
                {
                    Console.WriteLine("OK! You entered a lower case character!");
                    break;
                }
                while (char.IsLower(verify) == false)
                {
                    Console.WriteLine("You did not enter a lowercase letter. Try again.");
                    break;
                }
                Console.WriteLine("Do you want to start again? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepGoing = cki.KeyChar == 'y';

            }
        }
    }
}
