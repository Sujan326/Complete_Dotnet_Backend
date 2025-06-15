using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example();
            obj.InstanceMethod(); // Calling instance method
            Console.WriteLine();
            Example.StaticMethod(); // Calling static method
        }
    }

    class Example
    {
        public static string staticVariable = "I am static variable";
        public string instanceVariable = "I am instance variable";

        public void InstanceMethod()
        {
            Console.WriteLine("Inside Instance Method");
            Console.WriteLine(instanceVariable);
            Console.WriteLine(staticVariable);
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Inside Static Method");
            Console.WriteLine(staticVariable);
            // Console.WriteLine(instanceVariable); // This line will cause a compile-time error

            Example ob = new Example();
            Console.WriteLine(ob.instanceVariable); // This is valid.
        }
    }
}
