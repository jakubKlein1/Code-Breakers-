using System;
using System.Collections.Generic;

namespace AlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define test cases
            Dictionary<string, string> testCases = new()
            {
                { "Visma Labs Slovakia", "22 9 19 13 1 12 1 2 19 19 12 15 22 1 11 9 1" },
                { "I love code fights!", "9 12 15 22 5 3 15 4 5 6 9 7 8 20 19" }
            };

            // Test the function with each test case
            foreach (var testCase in testCases)
            {
                string input = testCase.Key;
                string expected = testCase.Value;
                string result = AlphabetSolution(input);
                Console.WriteLine("Input: " + input);
                Console.WriteLine("Expected: " + expected);
                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static string AlphabetSolution(string text)
        {
            string result = "";
            foreach (char c in text.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    int position = c - 'a' + 1;
                    result += position + " ";
                }
            }
            // remove the trailing space if any
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
    }
}
