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
            Console.WriteLine("Making Decisions");
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
            Console.WriteLine();
            Console.WriteLine("To select a chapter please enter the chapter topic.");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "making decisions":
                    MakingDecisions.index();
                    break;
                case "looping":
                    Looping.index();
                    break;
                case "using arrays":
                    Arrays.index();
                    break;
                case "using methods":
                    Methods.index();
                    break;
                case "advanced methods":
                    AdvancedMethods.index();
                    break;
                case "using classes and objects":
                    ClassesObjects.index();
                    break;
                case "inheritance":
                    Inheritance.index();
                    break;
                case "exception handling":
                    ExceptionHandling.index();
                    break;
                case "using controls":
                    Controls.index();
                    break;
                case "handling events":
                    HandlingEvents.index();
                    break;
                case "files and streams":
                    FilesStreams.index();
                    break;
                case "linq":
                    Linq.index();
                    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                    break;
            }
        }
    }
}
