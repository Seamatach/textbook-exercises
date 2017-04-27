using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbook
{
    class Methods
    {
        public static void index()
        {
            Console.WriteLine("Welcome to the chapter on methods.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to:");
            Console.WriteLine("Generate Memo");
            //Console.WriteLine("Check Lower");
            //Console.WriteLine("Average Calc");
            //Console.WriteLine("Yard sale");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "generate memo":
                    GenerateMemo();
                    break;
                //    case "check lower":
                //        CheckLower();
                //        break;
                //    case "average calc":
                //        AverageCalc();
                //        break;
                //    case "yard sale":
                //        YardSale();
                //        break;
                //    default:
                //        Console.WriteLine("This is not a valid selection. Please try again.");
                //        break;

                // Need to add an exit option here and at all menus in all classes.
            }
        }

        public static void GenerateMemo()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("Do you wish to generate a memo?");
                Console.WriteLine("Please type yes");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input == "yes")
                {
                    Console.WriteLine("To whom it may concern:");
                    Console.WriteLine();
                    Console.Write("Employees of ");
                    DisplayCompanyName();
                    Console.Write(". Be advised that we are currently undergoing a restructuring. ");
                    DisplayCompanyName();
                    Console.Write(
                        " is currently evalutating our staffing levels and will be making some hard decisions about our business state to ensure ");
                    DisplayCompanyName();
                    Console.Write(" has the best chance of survival from here on out.");
                }

                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static void DisplayCompanyName()
        {
            Console.Write("C# Software Developers");
        }

        //    public static void Method2()
        //    {
        //        bool keepPlaying = true;
        //        while (keepPlaying)
        //        {


        //            ConsoleKeyInfo cki = Console.ReadKey(true);
        //            keepPlaying = cki.KeyChar == 'y';
        //        }
        //    }

        //    public static void Method3()
        //    {
        //        bool keepPlaying = true;
        //        while (keepPlaying)
        //        {


        //            ConsoleKeyInfo cki = Console.ReadKey(true);
        //            keepPlaying = cki.KeyChar == 'y';
        //        }
        //    }

        //    public static void Method4()
        //    {
        //        bool keepPlaying = true;
        //        while (keepPlaying)
        //        {


        //            ConsoleKeyInfo cki = Console.ReadKey(true);
        //            keepPlaying = cki.KeyChar == 'y';
        //        }
        //    }
    }
}