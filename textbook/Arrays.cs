using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbook
{
    class Arrays
    {
        public static void index()
        {
            Console.WriteLine("Welcome to the chapter on arrays.");
            Console.WriteLine("Enter the exercise name to begin an exercise program.");
            Console.WriteLine("Please enter one of the following to:");
            Console.WriteLine("Array Operations");
            Console.WriteLine("Tips List");
            //Console.WriteLine("Compare Scores");
            //Console.WriteLine("Yard sale");

            string input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "array operations":
                    IntArray();
                    break;
                case "tips list":
                    TipsList();
                    break;
                case "compare scores":
                    CompareScores();
                    break;
                //case "yard sale":
                //    YardSale();
                //    break;
                default:
                    Console.WriteLine("This is not a valid selection. Please try again.");
                    break;

                // Need to add an exit option here and at all menus in all classes.
            }
        }

        public static void IntArray()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                string input = "";
                int[] numbers = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}; //This creates the array variable and the actual array to hold 10 ints in memory as well. This can be seperated into int[] numbers; and numbers = new int[10];
                int i;

                Console.WriteLine("An array has been generated. This array has 10 integers. There are three options to do things with this array:");
                Console.WriteLine("A. View integers in order added.");
                Console.WriteLine("B. View integers in reverse order.");
                Console.WriteLine("C. View a specific integer.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter A, B, or C to make your selection.");

                input = Console.ReadLine();
                input = input.ToLower();
                if (input == "a")
                {
                    for (i = 0; i < numbers.Length; i++)
                    {
                        int position = i + 1;
                        Console.WriteLine($"Array position {position} contains {numbers[i]}");
                    }
                }
                if (input == "b")
                {
                    Array.Reverse(numbers);
                    for (i = 0; i < numbers.Length; i++)
                    {
                        int position = i + 1;
                        Console.WriteLine($"Array position {position} contains {numbers[i]}");
                    }
                }
                if (input == "c")
                {
                    Console.WriteLine("What position do you want to see?");
                    int view = Convert.ToInt32(Console.ReadLine());
                    view = view - 1;
                    Console.WriteLine(numbers[view]);
                }
                Console.WriteLine("Keep going?");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static void TipsList()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                string input = "";
                int[] TipsList = new int[7];
                string[] Days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
                Console.WriteLine("Please enter your tips for the day starting with Sunday and ending with Saturday.");

                for (int i = 0; i < 7; i++)
                {
                    TipsList[i] = Convert.ToInt32(Console.ReadLine());
                }

                double a = 0;
                double b = 0;
                double c = 0;

                for (int i = 0; i < 7; i++)
                {
                    a = a + TipsList[i];
                    b = a/7;
                    b = Math.Floor(b);
                }
                Console.WriteLine(b);

                for (int i = 0; i < 7; i++)
                {
                    c = TipsList[i] - b;
                    Console.WriteLine($"The tip for {Days[i]} was ${TipsList[i]} and it is ${c} away from the average of ${b}.");
                }

                Console.WriteLine("Press \"y\" to keep going?");
                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static void CompareScores()
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {


                ConsoleKeyInfo cki = Console.ReadKey(true);
                keepPlaying = cki.KeyChar == 'y';
            }
        }

        public static void Array4()
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
