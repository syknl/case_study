using System;
using System.Text.RegularExpressions;

namespace case_study_core
{
    public class Program
    {
        public static void Main()
        {
            const int nameLengthLimit = 20;

            string firstName = GetInput("What is your first name?", nameLengthLimit);
            string lastName = GetInput("What is your last name?", nameLengthLimit);

            ProcessNames(firstName, lastName);
        }

        public static string GetInput(string message, int lengthLimit)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            if (!IsLessThanLimit(name, lengthLimit) || !IsAlphabet(name))
            {
                Environment.Exit(0);
            }

            return name;
        }

        public static bool IsLessThanLimit(string name, int nameLengthLimit) {
            bool boolV = true;
            var len = name.Length;
            if (len > nameLengthLimit)
            {
                var str = "Please enter maximum " + $"{nameLengthLimit}" + " characters.";
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
                Console.WriteLine("Please enter only alphabetical charaters.");
                boolV = false;
            }
            return boolV;
        }

        public static void ProcessNames(string firstName, string lastName)
        {
            for (int i = 1; i <= 100; i++)
            {
                var strOut = CalcFizzBuzz(firstName, lastName, i);
                Console.WriteLine(strOut);
            }
            return;
        }

        public static string CalcFizzBuzz(string firstName, string lastName, int num)
        {
            string str = (num % 3 == 0 ? firstName : "") + (num % 15 == 0 ? " " : "") + (num % 5 == 0 ? lastName : "");
            return (str.Length == 0 ? $"{num}" : str);
        }
    }
}
