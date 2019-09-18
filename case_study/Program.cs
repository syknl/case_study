using System;
using System.Text.RegularExpressions;

namespace case_study_core
{
    public class Program
    {
        public static void Main()
        {
            // Limit of name length.
            const int length_limit = 20;

            string first_name = Get_input("What is your first name?", length_limit);
            string last_name = Get_input("What is your last name?", length_limit);

            // The maximum of the loop.
            const int max_num = 100;

            for (int i = 1; i <= max_num; i++)
            { 
                string str_out = Fizzbuzz_like(first_name, last_name, i);
                Console.WriteLine(str_out);

            }
        }

        public static string Get_input(string message, int length_limit)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();

            //Checking length of the names and exiting if too long.
            int len = name.Length;
            if (len > length_limit)
            {
                string str = "Please enter " + $"{length_limit}" + " or less number of characters.";
                Console.WriteLine(str);
                Environment.Exit(0);

            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) {
                Console.WriteLine("Please enter only alphabets.");
                Environment.Exit(0);
            }

            return name;
        }

        public static string Fizzbuzz_like(string first_name, string last_name, int num)
        {
            string str1 = (num % 3 == 0 ? first_name : "") + (num % 15 == 0 ? " " : "") + (num % 5 == 0 ? last_name : "");
            string str2 = (str1 == "" ? $"{num}" : str1);
            return str2;
        }
    }
}
