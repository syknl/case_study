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
        }

        public static string GetInput(string message, int lengthLimit)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            //Checking the length and character type, only alphabets are accepted.
            if (!IsLessThanLimit(name, lengthLimit) || !IsAlphabet(name))
            {
                Environment.Exit(0);
            }

            return name;
        }

        public static bool IsLessThanLimit(string name, int lengthLimit) {
            bool boolV = true;
            var len = name.Length;
            if (len > lengthLimit)
            {
                var str = "Please enter " + $"{lengthLimit}" + " or less number of characters.";
                Console.WriteLine(str);
                boolV = false;
            }
            return boolV;
        }

        public static bool IsAlphabet(string name)
        {
            bool boolV = true;
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Please enter only alphabets.");
                boolV = false;
            }
            return boolV;
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
