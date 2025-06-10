using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Variable is the named memory location in RAM that stores the particular type of value, during the program execution.
                -> All variables will be stored in the stack memory.
                -> For every method call a new stack will be created.
                -> The value of the variable can be changed any number of times.
                -> The variable must be declared before it is used.
                -> The variable data type must also be declared while declaring the variable.
                -> The stack that is created will be deleted once the method execution is completed.

                Syntax:
                dataType variableName = value;
            */

            // Declare the variable
            string studentName = "Sujan";
            int age = 23;

            // Print the value
            Console.WriteLine("Hi " + studentName + ", your age is " + age);
            Console.ReadKey();
        }
    }
}
