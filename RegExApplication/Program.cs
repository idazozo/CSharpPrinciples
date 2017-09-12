using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    // A regular expression is a pattern that could be matched against an input text.
    // The .Net framework provides a regular exoression ebgin theat allows such matching.
    // A pattern consists of one or more character literals, operators, or constructs.
    class Program
    {
        static void Main(string[] args)
        {
            // \b is a zero with assertion. That means it does not match a character, it
            // matches a position with one thing on the left side and another thing on the 
            // right side.

            // \s matches any white-space character
            // \S matches any non-white-space character
            // \d matches any decimal digit
            // \w matches any word character
            // * matches the previous element zero or more times
            // + matches the previous element one or more times
            // ? matches the previous element zero or one time
            // [ char_group ] matches any single character in char_group. By defalt, the match
            // is case-sensitive.
            // [ ^char_group ] matches any single character that is not in char_group. By defalt,
            // characters in char_group are case-sensitive.

            // Example 1
            string str = "A Thousand Splendid Suns";

            Console.WriteLine("Matching words that start with 'S': ");
            showMatch(str, @"\bS\S*");

            // Example 2
            string str2 = "make maze and manage to measure it";

            Console.WriteLine("Matching words start with 'm' and ends with 'e'");
            showMatch(str2, @"\bm\S*e\b");

            // Example 3
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);

            // Example 4
            string wordTest = "ID A1.3";
            showMatch(wordTest, @"\w");

            Console.ReadKey();
        }

        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach( Match m in mc )
            {
                Console.WriteLine(m);
            }
        }
    }
}
