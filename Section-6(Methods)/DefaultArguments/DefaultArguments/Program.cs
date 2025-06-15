using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Default arguments allow us to specify the default value for the parameter in a static or instance methods.
                -> If the caller does not provide a value for that parameter, the default value is used.
                -> Syntax
                   public void MethodName(int param1, int param2 = 10)
                   {
                       // method body
                   }
                -> In the above example, if the caller does not provide a value for param2, it will default to 10.
                -> If the caller provides a value for param2, that value will be used instead of the default value. So default arguments are called as Optional Arguments.
            */
            double cost = 20000;
            double taxCalulated = CalculateTax(cost, 15.0);
            Console.WriteLine($"Cost: {cost}, Tax Calculated: {taxCalulated}");
            Console.WriteLine($"Total Paying Amount is: {cost + taxCalulated}");
        }

        public static double CalculateTax(double cost, double taxPercent = 12.5)
        {
            double taxAmount;
            if(cost <= 20000)
            {
                taxAmount = cost * 10 / 100;
            }
            else
            {
                taxAmount = cost * taxPercent / 100;
            }
            return taxAmount;
        }
    }
}
