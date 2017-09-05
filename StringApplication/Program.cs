using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApplication
{
    class StringPro
    {
        static void Main(string[] args)
        {
            // Comparing Strings:
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }

            // String contains String:
            if (str1.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            // Getting a Substring:
            string str = "Last night I dreamt of San Pedro";
            string substr = str.Substring(23);
            Console.WriteLine("The substring from position 23 is " + substr);

            // Joining Strings:
            string[] starray = new string[]{"Down the way nights are dark",
                     "And the sun shines daily on the mountain top",
                     "I took a trip on a sailing ship",
                     "And when I reached Jamaica",
                     "I made a stop"};

            string str3 = String.Join("\n", starray);
            Console.WriteLine(str3);

            Console.ReadKey();
        }
    }
}
