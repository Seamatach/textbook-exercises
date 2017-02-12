using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my textbook exercise program!");
            Console.WriteLine("This program is broken down chapter by chapter and by exercise.");
            Console.WriteLine("Please select a chapter to go to the chapter page. The chapter page will have a list of available exercises.");
            Console.WriteLine("Making decisions");
            Console.WriteLine("Looping");
            Console.WriteLine("Using Arrays");
            Console.WriteLine("Using Methods");
            Console.WriteLine("Advanced Methods");
            Console.WriteLine("Using Classes and Objects");
            Console.WriteLine("Inheritance");
            Console.WriteLine("Exception Handling");
            Console.WriteLine("Using Controls");
            Console.WriteLine("Handling Events");
            Console.WriteLine("Files and Streams");
            Console.WriteLine("LINQ");
            Console.WriteLine("To select a chapter please enter the chapter topic.");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "making decisions":
                    MakingDecisions.main();
                    break;
                case "looping":
                    Looping.main();
                    break;
                case "using arrays":
                    Arrays.main();
                    break;
                case "using methods":
                    Methods.main();
                    break;
                case "advanced methods":
                    AdvancedMethods.main();
                    break;
                case "using classes and objects":
                    ClassesObjects.main();
                    break;
                case "inheritance":
                    Inheritance.main();
                    break;
                case "exception handling":
                    ExceptionHandling.main();
                    break;
                case "using controls":
                    Controls.main();
                    break;
                case "handling events":
                    HandlingEvents.main();
                    break;
                case "files and streams":
                    FilesStreams.main();
                    break;
                case "linq":
                    Linq.main();
                    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                    break;
            }
        }
    }
}
