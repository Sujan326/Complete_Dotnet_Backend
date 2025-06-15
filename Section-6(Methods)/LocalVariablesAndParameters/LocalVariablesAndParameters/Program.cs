using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVariablesAndParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                LOCAL VARIABLES
                -> All the variables that are created inside the method boy are called as Local Variables.
                -> Local variables are declared, initialized and used within the method itself.
                -> Local variables are not accessible outside the method in which they are declared.
                -> Local variables are created when the method is called and destroyed when the method execution is completed.

                PARAMETERS
                -> The variables that are being received by the method caller are called as Parameters.
                -> In simple words when we pass any value when we are calling the method like methodName(100) this 100 is called as Parameter in the method declaration. And when we pass the value 100 like that in the method caller then it is called as Argument.
             */

            string name = EnterName("Sujan"); // Argument
            Console.WriteLine(name);
        }

        public static string EnterName(string name) // Parameter
        {
            return "Hello, " + name;
        }
    }
}
