using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Program
    {
        // Example of Default Modifier
        static int DefaultModifier(int a, int b)
        {
            a = 10;
            b = 20;
            return a + b; // returns 30
        }

        // Example of ref Modifier
        static int RefModifier(ref int a, ref int b)
        {
            a = 10;
            b = 20;
            return a + b; // returns 30
        }

        static void Main(string[] args)
        {
            /*
                -> C# supports 4 kinds of parameter modifiers.
                -> Parameter modifiers defines how the parameter must receive the value.

                    - Default (No Keyword) : 
                        => There is no keyword called default here.
                        => The default modifier for the parameters are Default only.
                        => Here in the default modifier the parameter value that is changed will not effect the argument.
                        => The argument can be passed with the variable or directly we can give the value, like methodName(5, 10)
                        => What Default Modifier says is: “I want to give you a copy. Use it however you want inside the method, but don’t touch the original.”

                    - ref :
                        => The ref modifier indicates that an argument is passed by reference.
                        => Here the ref modifier tells that the changes that is made in the parameter will be reflected in the argument also.
                        => The argument that will be passed should be a variable and we should be prefix the keyword ref.
                        => Before passing the variable as the argument we should intialize it.
                        => What ref Modifier says is: “I want to give you a reference. Use it however you want inside the method, and the changes will be reflected in the original argument.”


                    - out :

                    - in
                    - params
            */

            // 1. Example of Default Modifier
            // This is nothing but pass-by-value, (Here the original argument value is not changed because this is stored in the stack of main method and the DefautModifier method has its own stack and the values are copied to the stack of DefaultModifier method. So the original value of a and b will not be changed.)
            int a = 5, b = 10;
            int result = DefaultModifier(a, b); 
            Console.WriteLine($"Default Modifier Output: {result} ");

            Console.WriteLine();

            // 2. Example of ref Modifier
            int x = 5, y = 10;
            int refResult = RefModifier(ref x, ref y);
            Console.WriteLine($"Ref Modifier Output: {refResult}"); // Output: 30


        }
    }
}
