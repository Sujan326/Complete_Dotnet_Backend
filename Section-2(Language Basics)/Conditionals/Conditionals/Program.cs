using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Control Statments are used to control the flow of execution of a program.
                -> There are three types of control statements:
                    1. Conditional Statements
                        - if, else if, else, nested-if, switch
                    2. Looping Statements
                        - for, while, do while, foreach
                    3. Jump Statements
                        - break, continue, return, goto
                -> Conditional statements are used to execute a block of code based on a condition.

                1. if statement
                if (condition)
                {
                    // true block executed
                }

                2. if-else statement
                if (condition)
                {
                    // true block executed
                }
                else
                {
                    // false block executed
                }

                3. if-else if-else statement
                if (condition1)
                {
                    // true block executed
                }
                else if (condition2)
                {
                    // second true block executed only if condition1 is false
                }
                else
                {
                    // false block executed if both conditions are false
                }

                4. Nested if statement
                if (condition1)
                {
                    // true block executed
                    if (condition2)
                    {
                        // second true block executed only if condition1 is true
                    }
                    else
                    {
                        // false block executed if condition2 is false
                    }
                }
                else
                {
                    // false block executed if condition1 is false
                }

                5. switch statement: It is used to execute one block of code among many alternatives based on the value of an expression.
                switch (expression)
                {
                    case value1:
                        // code block executed if expression matches value1
                        break;
                    case value2:
                        // code block executed if expression matches value2
                        break;
                    default:
                        // code block executed if no case matches
                        break;
                }
            */

            // Example of if statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }

            // Example of if-else statement
            if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is non-negative.");
            }

            // Example of if-else statement
            if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else
            {
                Console.WriteLine("The number is positive.");
            }

            // Example of nested if statement
            if (number >= 0)
            {
                Console.WriteLine("The number is non-negative.");
                if (number == 0)
                {
                    Console.WriteLine("The number is zero.");
                }
                else
                {
                    Console.WriteLine("The number is positive.");
                }
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }

            // Example of switch statement
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero.");
                    break;
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                default:
                    Console.WriteLine("The number is greater than two or less than zero.");
                    break;
            }


        }
    }
}
