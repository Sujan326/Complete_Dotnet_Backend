using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVariablesAsArguments
{

    class Example
    {
        public string name;
    }

    internal class Program
    {
        /*
            -> If you pass "reference variable" as argument, the reference (address) of object will be passed to the method.
            -> The parameter's data type will be the class name.
            -> If you make any changes to object in the method, the same will be affected automatically in the caller method, as you are accessing the same object.
        */
        static void ChangeName(Example person)
        {
            person.name = "Changed Name";
        }

        static void Main(string[] args)
        {
            Example person1 = new Example();
            person1.name = "Original Name"; // Initialize the name field for class Example

            Console.WriteLine($"Before Calling the Change Name method {person1.name} ");

            ChangeName(person1); // Pass the object reference to the method, Here it changes the name 

            Console.WriteLine($"After Calling the Change Name method {person1.name} ");
        }
    }
}
