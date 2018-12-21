using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
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
            Console.WriteLine("Siding Estimator");
            Console.WriteLine("Convert inches to cm");
            Console.WriteLine("Yard sale");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "generate memo":
                    GenerateMemo();
                    break;
                case "siding estimator":
                    SidingEstimate();
                    break;
                case "convert inches to cm":
                    ConvertInchesToCm();
                    break;
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

                Console.WriteLine("Do you want to create another memo?");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }
         
        public static void DisplayCompanyName()
        {
            Console.Write("C# Software Developers");
        }

        public static void SidingEstimate()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                int estimated;
                Console.WriteLine("What is the length of the house?");
                int lengthHouse = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the depth of your house?");
                int depthHouse = Convert.ToInt32(Console.ReadLine());

                estimated = Estimator(lengthHouse, depthHouse);
                Console.WriteLine($"Your estimate is {estimated}.");

                Console.WriteLine("Do you have another estimate");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static int Estimator(int length, int depth)
        {
            int cost = 5;
            int area = length * depth;
            int subTotalCost = cost * area;
            
            return subTotalCost;
        }

        public static void ConvertInchesToCm()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.WriteLine("How many inches to convert?");
                double inches = Convert.ToInt32(Console.ReadLine());

                double newLength = Convertor(inches);
                Console.WriteLine($"{inches} is converted to: {newLength} centimeters.");
                Console.WriteLine("Do you want to do another inch conversion?");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static double Convertor(double inch)
        {
            double cm = 2.54;
            double converted = inch * cm;
            return converted;
        }

        public static void YardSale()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {


                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }
    }
}