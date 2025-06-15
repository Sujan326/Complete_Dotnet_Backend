using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Example
    {
        public int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public double AddNumbers(double number1, double number2)
        {
            return number1 + number2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Writing multiple methods with the same name but with different parameters in the same class is called as Method Overloading.
                -> Caller will be having several options to use the same method with different types of parameters.
            */

            Example example = new Example();
            Console.WriteLine(example.AddNumbers(1, 2)); // Here the user will be having multiple option so they can pass either the decimal value or the whole integers.
        }
    }
}
