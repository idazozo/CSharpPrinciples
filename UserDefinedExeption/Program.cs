using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExeption
{
    public class TempIsZeroException: Exception
    {
        public TempIsZeroException(string message): base(message)
        {
        }
    }

    public class Temperature
    {
        private int temperature;
        public Temperature(int temp)
        {
            temperature = temp;
        }
        
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the temperature of today: ");
            int temperature = Int32.Parse(Console.ReadLine());
            Temperature temp = new Temperature(temperature);
            try
            {
                temp.showTemp();
            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
