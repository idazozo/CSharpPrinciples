using System;

namespace InheritanceApplication
{
    /* The syntax used in C# for creating derived classes is as folllows:
        <access-specifier> class <base_class>
        {
            ...
        }
        classs <derived_class> : <base_class>
        {
            ...
        }
        */
    class Rectangle
    {
        protected double width;
        protected double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double GetArea()
        {
            return (width * height);
        }

        public void Display()
        {
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    // C# does not support multiple inheritance. However, you can use interfaces to 
    // implement multiple inheritance.

    // Base class PaintCost
    public interface PaintCost
    {
        double GetCost();
    }

    // Derived class
    class Tabletop : Rectangle, PaintCost
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w)
        { }
        public double GetCost()
        {
            return GetArea() * 70;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Total paint cost: ${0}", GetCost());
        }
    }


    class RectangleTester
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadKey();
        }
    }
}