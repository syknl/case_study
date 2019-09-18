using System;
using System.Text.RegularExpressions;

namespace case_study_core
{
    public class Program
    {
        public static void Main()
        {
            // Limit of name length.
            const int lengthLimit = 20;

            string firstName = GetInput("What is your first name?", lengthLimit);
            string lastName = GetInput("What is your last name?", lengthLimit);

            FizzbuzzLikeAll(firstName, lastName);
            //for (int i = 1; i <= 100; i++)
            //{ 
            //    string strOut = FizzbuzzLikeEach(firstName, lastName, i);
            //    Console.WriteLine(strOut);

            //}
        }

        public static string GetInput(string message, int lengthLimit)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            // todo: move to own method.
            // todo: remove comment
            //Checking length of the names and exiting if too long.
            int len = name.Length;
            if (len > lengthLimit)
            {
                string str = "Please enter " + $"{lengthLimit}" + " or less number of characters.";
                Console.WriteLine(str);
                Environment.Exit(0);

            }

            // todo: move to own method
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) {
                Console.WriteLine("Please enter only alphabets.");
                Environment.Exit(0);
            }

            return name;
        }

        public static string FizzbuzzLikeEach(string firstName, string lastName, int num)
        {
            string str = (num % 3 == 0 ? firstName : "") + (num % 15 == 0 ? " " : "") + (num % 5 == 0 ? lastName : "");
            return (str.Length == 0 ? $"{num}" : str);
        }

        public static void FizzbuzzLikeAll(string firstName, string lastName)
        {
            for (int i = 1; i <= 100; i++)
            {
                var strOut = FizzbuzzLikeEach(firstName, lastName, i);
                Console.WriteLine(strOut);
            }
            return;
        }
    }
}
