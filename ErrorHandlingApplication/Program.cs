using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingApplication
{
    // try: A try block identifies a block of code for which particular exceptions
    // is activated. It is followed by one or more catch blocks.

    // catch: A program catches an exception with an exception handler at the place 
    // in a program where you want to handle tha problem. The catch keyword indicates
    // the catching of an exception.

    // finally: The finally block is used to execute a given set of statements, whether
    // an exception is thrown or not thrown. For example, if you open a file, it must
    // be closed whether an exception is raised or not.

    // throw: A program throws an exception when a problem shows up. 

    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result:{0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(42, 0);
            Console.ReadKey();
        }
    }
}
