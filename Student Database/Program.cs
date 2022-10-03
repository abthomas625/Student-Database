using System.Net.NetworkInformation;

namespace Student_Database
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the student database!");
            string[] students = { "Angela", "Billy", "Theresa", "George", "Harold" };
            string[] favfoods = { "spaghetti", "steak", "raspberries", "cereal", "lasagna" };
            string[] hometown = { "Chicago", "Detroit", "Grand Rapids", "Detroit", "Detroit" };
            Console.WriteLine("Would you like to see a list of students? Y/N");
            string response = Console.ReadLine().ToLower();

            if(response == "y")
            {
                PrintNames(students);
            }

            bool goOn =true;

            while (goOn == true)
            {   
                

                Console.WriteLine("Input a number between 1 and 5 to learn a student's name.");
                int data = int.Parse(Console.ReadLine());
                if (data >= 1 && data <= 5)
                {

                    Console.WriteLine("Student Name: " + students[data - 1]);

                    Console.WriteLine("Would you like to learn about their hometown or their favorite food?");
                    string input = Console.ReadLine().ToLower();
                    if (input == "hometown" || input == "town")
                    {
                        Console.WriteLine("Hometown: " + hometown[data - 1]);
                    }
                    else if (input == "favorite food" || input == "food")
                    {
                        Console.WriteLine("Favorite Food: " + favfoods[data - 1]);
                    }
                    else
                    {
                        Console.WriteLine("That is unavailable. Please try again.");
                        continue;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                goOn = AskToContinue();
            }
        }

        public static void PrintNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();
        }
        static bool AskToContinue()
        {
            Console.WriteLine("Would you like to continue? Y/N");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Input invalid. Please try again.");
                return AskToContinue();
            }
        }
    }
}