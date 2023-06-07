using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class RequestData
    {
        public static string GetAString(string message)
        {
            Console.WriteLine(message);
            string? result = Console.ReadLine();
            return result;
        }
        
        public static double GetADouble(string message)
        {
            Console.WriteLine(message);
            double result;
            string output = Console.ReadLine();
            bool isDouble = double.TryParse(output, out result);
            while(isDouble == false)
            {
                Console.WriteLine("That was not a valid number , Please Try again...");
                Console.WriteLine(message);
                output = Console.ReadLine();
                isDouble = double.TryParse(output, out  result);
            }

            return result;

        }
    }
}
