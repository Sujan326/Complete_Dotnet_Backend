using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> The `this` keyword in C# is used to refer to the current object of a class.
                -> The 'this' keyword is only avilable for the instance methods, means non-static methods.
                -> If the parametes name is not same as the variable name that is used inside the method, then there is no need to use the 'this' keyword.
            */

            // Here the 'this' keyword in the constructor refers to the first object that is created which is Sujan.
            // And next 'this' keyword in the constructor refers to the second object that is created which is Ramesh.

            Person p1 = new Person("Sujan");
            p1.Display();

            Person p2 = new Person("Ramesh");
            p2.Display();
        }
    }

    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name; // 'this' refers to current object. (First the current object is "Sujan" and the Second the current object is "Ramesh".)
            // name = n; -> If the above line was like this where the parameter name and the variable name are not same, here there is no need to use the 'this' keyword.
        }

        public void Display()
        {
            Console.WriteLine($"{this.name}, Welcome.");
        }
    }
}
