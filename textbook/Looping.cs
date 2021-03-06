﻿/* This cs page is on loops. There are again several small projects that focus on using looping as a key logic component of the program.
 * In line documentation is presented before the method and where it will be relevant.
 */

using System;

namespace textbook
{
    class Looping
    {
        /// <summary>
        /// This is the class specific main function for my programs. They are simple switch statements to direct the user to the right mini program.
        /// </summary>
        public static void index()
        {
            Console.WriteLine("Welcome to the chapter on looping.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to:");
            Console.WriteLine("Adding Doubles");
            Console.WriteLine("Check Lower");
            Console.WriteLine("Average Calc");
            Console.WriteLine("Yard sale");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "adding calc":
                    AddingCalc();
                    break;
                case "check lower":
                    CheckLower();
                    break;
                case "average calc":
                    AverageCalc();
                    break;
                case "yard sale":
                    YardSale();
                    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                    break;
                    
                    // Need to add an exit option here and at all menus in all classes.
            }
        }

        /// <summary>
        /// This is a simple adding calculator. I have a while loop to allow another set of additions or to exit the app, and a simple while loop statement as the logic of the calculator.
        /// </summary>
        public static void AddingCalc()
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

        /// <summary>
        /// This is a simple app to verify a lower case letter has been typed. I have a while loop to allow another letter to be verified or to exit the app, and two simple while loop statements as the logic of the app.
        /// </summary>
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

        /// <summary>
        /// This is a simple app to average a set of provided values. I have a while loop to begin again or to exit the app, and 
        /// </summary>
        public static void AverageCalc()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                int totalValues = 0;
                int values, average;
                int count = 0;
                string sentinal = "999";
                int min = 300;
                int max = 900;
                string input;

                Console.WriteLine(
                    "This calculator will accept any number of numeric values within the range of 300 and 900. Once the exit command is given of 999, it will calculate the average and display it.");
                Console.WriteLine("Please enter the first value.");
                input = Console.ReadLine();
                values = Convert.ToInt32(input);
                count = ++count;
                totalValues += values;

                while (input != sentinal)
                {
                    Console.WriteLine("Enter a valid value or 999 to exit.");
                    input = Console.ReadLine();
                    values = Convert.ToInt32(input);

                    if (values >= min && values <= max)
                    {
                        count = ++count;
                        totalValues += values;
                    }
                    else
                    {
                        Console.WriteLine("Invalid value. Please enter a valid value.");
                    }
                    
                }
                average = totalValues/count;
                Console.WriteLine("You have entered {0} numbers. Your average is {1}.", count, average);

                Console.WriteLine("Do you want to start again? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepGoing = cki.KeyChar == 'y';
            }
        }

        /// <summary>
        /// Exercise is to track the amount earned by the families (a, b, and c) and to return the amount each family has earned and a grand total for the sale.
        /// </summary>
        public static void YardSale()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                int famA = 0;
                int famB = 0;
                int famC = 0;
                int total = 0;
                string a = "a", b = "b", c = "c", exit = "exit";
                string sale;
                string input = "";

                while (input != exit)
                {
                    Console.WriteLine("Welcome to the Yard Sale! Please pick a family to track a sale.");
                    Console.WriteLine("Are you tracking a sale with Family A, B, or C. If you are done added sales type Exit.");
                    input = Console.ReadLine();
                    input = input.ToLower();

                    if (input == a)
                    {
                        Console.WriteLine("How much did Family A sell?");
                        sale = Console.ReadLine();
                        int addA = Convert.ToInt32(sale);
                        famA = famA + addA;
                    }
                    if (input == b)
                    {
                        Console.WriteLine("How much did Family B sell?");
                        sale = Console.ReadLine();
                        int addB = Convert.ToInt32(sale);
                        famB = famB + addB;
                    }
                    if (input == c)
                    {
                        Console.WriteLine("How much did Family A sell?");
                        sale = Console.ReadLine();
                        int addC = Convert.ToInt32(sale);
                        famC = famC + addC;
                    }
                }
                total = famA + famB + famC;
                Console.WriteLine($"The total sold by the families was {total}.");
                
                Console.WriteLine("Do you want to start again? (Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepGoing = cki.KeyChar == 'y';
            }
        }
    }
}
