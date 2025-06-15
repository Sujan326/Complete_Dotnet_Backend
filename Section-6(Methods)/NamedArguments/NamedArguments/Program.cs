using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    internal class Program
    {

        static void DisplayDetails(string name, int age, string gender)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Gender: {gender}");
        }

        static void Main(string[] args)
        {
            /*
                -> Named arguments allow you to specify the name of the parameter when calling a method.
                -> This can make the code more readable and allows you to pass arguments in any order.
                -> Named arguments are particularly useful when a method has many parameters, or when some parameters have default values.
            */

            //Normal Argument passing (Postional)
            DisplayDetails("Sujan", 23, "Male");

            // Named Argument passing
            DisplayDetails(name: "Sujan", age: 23, gender: "Male"); // Here we can also change the order of the arguments.
        }
    }
}
