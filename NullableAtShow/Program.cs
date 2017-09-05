using System;
namespace CalculatorApplication
{
    class NullableAtShow
    {
        // Syntax for declaring a nullable type is as follows:
        // <data_type> ? <variable_name> = null/value;

        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);

            bool? boolval = new bool?();
            Console.WriteLine("A Nullable boolean value: {0}", boolval);

            // Null Coalescing Operator (??)
            // If the value of the first oprand is null, then the operator 
            // returns ther value of the second sperand, otherwise it returns
            // thr value of the first operand.
            double num6;
            num6 = num1 ?? 5.34;
            Console.WriteLine("Value of num6: {0}", num6);

            num6 = num4 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num6);

            // diapley the values

            Console.ReadKey();
        }
    }
}