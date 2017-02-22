/* This program is an exercise test in making various exercise examples of small C# programs.
 * These exercises are from Visual C# 2012: An Introduction to Object-Oriented Programming by Joyce Farrell.
 * This cs page is where the program starts and where the user decides what set of exercises to experience and test.
 * These are all simple games or tools.
 */

using System;

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
            Console.WriteLine("Arrays");
            Console.WriteLine("Methods");
            Console.WriteLine("Advanced Methods");
            Console.WriteLine("Classes and Objects");
            Console.WriteLine("Inheritance");
            Console.WriteLine("Exception Handling");
            Console.WriteLine("Controls");
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
                case "arrays":
                    Arrays.index();
                    break;
                case "methods":
                    Methods.index();
                    break;
                case "advanced methods":
                    AdvancedMethods.index();
                    break;
                case "classes and objects":
                    ClassesObjects.index();
                    break;
                case "inheritance":
                    Inheritance.index();
                    break;
                case "exception handling":
                    ExceptionHandling.index();
                    break;
                case "controls":
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
