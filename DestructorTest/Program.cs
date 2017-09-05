using System;
namespace DestructorTest
{
    class Line
    {
        /* - A destructor is a special member function of a class that is executed whenever 
           an object of its class goes out of scope. 

           - A dectructor has exactly the same name aas that of the class with a prefixed
           tilde (~) and it can neither return a value nor can it take any parameters.

           - Destructor can be very useful for releasing memory resources before exiting the 
           program.*/

        private double length;  // Length of a line
        public Line()   // constructor
        {
            Console.WriteLine("Object is being created");
        }
        ~Line()     // destructor
        {
            Console.WriteLine("Object is being deleted");
        }

        public void setLength( Double len )
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
            Console.ReadKey();
        }

    }
}
