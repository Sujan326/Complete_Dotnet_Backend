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

        // Example of out Modifier
        static int OutModifier(out int a, out int b)
        {
            a = 10; // The value of a is assigned to the argument variable
            b = 20; // The value of b is assigned to the argument variable
            return a + b; // returns 30
        }

        // Example of in Modifier
        static int InModifier(in int a, in int b)
        {
            // a = 10; // This will give an error because 'a' is read-only
            // b = 20; // This will give an error because 'b' is read-only
            return a + b; // returns the sum of a and b
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
                        => In the out modifier the argument value will not be given to the parameter. The parameter value will be automatically assigned to the argument variable.
                        => The out modifier is used to pass arguments by reference.
                        => The flow of this modifier is from Method defination to Method Caller.
                        => The out modifier is used to return multiple values from a method.
                        => The argument that will be passed should be a variable and we should be prefix the keyword out.
                        => Before passing the variable as the argument we should not intialize it.
                        => What out Modifier says is: “I want to give you a reference. Use it however you want inside the method, and the changes will be reflected in the original argument, but I will not give you the original value.”

                    - in :
                        => The in modifier indicates that an argument is passed by reference, but it is read-only.
                        => The in modifier is used to pass arguments by reference, but the method cannot modify the value of the parameter.
                        => The argument that will be passed should be a variable and we should be prefix the keyword in.
                        => Before passing the variable as the argument we should intialize it.
                        => What in Modifier says is: “I want to give you a reference. Use it however you want inside the method, but don’t change the original argument value.”

                    - params :
                        => The params modifier allows us to take multiple arguments of the same type by declaring a parameter as an array.
                        => We can use the index to access the values of the array.
             
            */

            // 1. Example of Default Modifier
            // This is nothing but pass-by-value, (Here the original argument value is not changed because this is stored in the stack of main method and the DefautModifier method has its own stack and the values are copied to the stack of DefaultModifier method. So the original value of a and b will not be changed.)
            int a = 5, b = 10;
            int result = DefaultModifier(a, b); 
            Console.WriteLine($"Default Modifier Output: {result} "); // Output: 30

            Console.WriteLine();

            // 2. Example of ref Modifier
            int x = 5, y = 10;
            int refResult = RefModifier(ref x, ref y);
            Console.WriteLine($"Ref Modifier Output: {refResult}"); // Output: 30

            Console.WriteLine();

            // 3. Example of out Modifier
            int outA, outB; // No need to initialize these variables
            int outResult = OutModifier(out outA, out outB);

            // In the C# version 7 after, we can directly declare the out variables in the method call itself.
            // int outResult = OutModifier(out int outA, out int outB); // This is also valid.

            Console.WriteLine($"Out Modifier Output: {outResult}"); // Output: 30

            Console.WriteLine();

            // 4. Example of in Modifier
            int inA = 5, inB = 10;
            int inResult = InModifier(in inA, in inB);
            // Note: We cannot change the value of inA or inB inside the InModifier method.
            Console.WriteLine($"In Modifier Output: {inResult}"); // Output: 15

            Console.WriteLine();

            // 5. Example of params Modifier
            Student s = new Student();
            s.DisplaySubjects("Math", "Science", "English", "History", "Kannada");
        }
    }

    // Example for params Modifier
    public class Student
    {
        public void DisplaySubjects(params string[] subjects)
        {
            Console.WriteLine("Subjects...");
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"Subject-{i+1}: {subjects[i]}");
            }
        }
    }
}
