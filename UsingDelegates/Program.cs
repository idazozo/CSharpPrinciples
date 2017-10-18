using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelegateApplication
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        // Delegate declaration
        public delegate void printString(string s);

        // This method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine($"The String is: {str}");
        }

        //This method prints to a file
        public static void WriteToFile(string s)
        {
            fs = new FileStream("c:\\Temp\\message.txt",
                FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // This method takes the delegate as parameter and uses it to 
        // call the methods as required
        public static void sendString(printString ps)
        {
            ps("Hello World");
        }

        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            Console.ReadKey();
        }
    }
}
