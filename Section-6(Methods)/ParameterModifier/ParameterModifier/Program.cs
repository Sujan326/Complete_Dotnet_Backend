using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Program
    {

        static int DefaultModifier(int a, int b)
        {
            a = 10;
            b = 20;
            return a + b; // returns 30
        }

        static void Main(string[] args)
        {
            /*
                -> C# supports 4 kinds of parameter modifiers.
                    - Default (No Keyword) : 
                        => There is no keyword called default here.
                        => The default modifier for the parameters are Default only.
                        => Here in the default modifier the parameter value that is changed will not effect the argument.
                        => The argument that will be passed should not be literal, it should be a variable.
                        => What Default Modifier says is: “I want to give you a copy. Use it however you want inside the method, but don’t touch the original.”
                    - ref 
                    - out
                    - in
                    - params
                -> Parameter modifiers defines how the parameter must receive the value.
            */

            // Example of Default Modifier
            // This is nothing but pass-by-value, (Here the original argument value is not changed because this is stored in the stack of main method and the DefautModifier method has its own stack and the values are copied to the stack of DefaultModifier method. So the original value of a and b will not be changed.)
            int a = 5, b = 10;
            int result = DefaultModifier(a, b); 
            Console.WriteLine(result);


        }
    }
}
