using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Loops are used to execute a block of code repeatedly until a specified condition is met.
                -> The most common types of loops in C# are:
                    1. for loop
                    2. while loop
                    3. do-while loop
                    4. Nested loop
                    5. Break
                    6. Continue
                    7. Goto

                1. for loop:
                    - This loop is used when we exactly know the number of iteration.
                    - It is called as Entry Control Loop because it checks the condition before executing the loop body.
                    - This loop is used when we want to perform intialization, condition checking, and increment/decrement in a single line of code.
                Syntax:
                    for (initialization; condition; increment/decrement)
                    {
                        // Code to be executed
                    }

                2. while loop:
                    - This loop is used when we do not know the number of iterations in advance.
                    - It is also called as Entry Control Loop because it checks the condition before executing the loop body.
                    - this loop is used when we want to execute a block of code as long as a specified condition is true.
                Syntax:
                    while (condition)
                    {
                        // Code to be executed
                    }

               3. do-while loop:
                    - This loop is similar to the while loop, but it guarantees that the loop body will be executed at least once.
                    - It is called as Exit Control Loop because it checks the condition after executing the loop body.
                    - This loop is used when we want to execute a block of code at least once and then continue executing it as long as a specified condition is true.
                Syntax:
                    do
                    {
                        // Code to be executed
                    } while (condition);

                4. Nested loop:
                    - A nested loop is a loop inside another loop.
                    - It is used when we want to perform multiple iterations for each iteration of the outer loop.
                    - The inner loop will complete all its iterations for each iteration of the outer loop.
                Syntax:
                    for (initialization; condition; increment/decrement)
                    {
                        for (initialization; condition; increment/decrement)
                        {
                            // Code to be executed
                        }
                    }

                5. Break:
                    - The break statement is used to exit a loop prematurely.
                    - It can be used in any type of loop (for, while, do-while).
                    - When the break statement is encountered, the control exits the loop immediately.
                Syntax:
                    break;

                6. Continue:
                    - The continue statement is used to skip the current iteration of a loop and move to the next iteration.
                    - It can be used in any type of loop (for, while, do-while).
                    - When the continue statement is encountered, the control skips the remaining code in the current iteration and jumps to the next iteration.
                Syntax:
                    continue;

                7. Goto:
                    - The goto statement is used to transfer control to a labeled statement in the code.
                    - It can be used to jump to a specific point in the code, but its use is generally discouraged as it can make code harder to read and maintain.
                    - It is not commonly used in modern programming practices.
                    - Here the label is given just above the code very we wanted to jump to and we will use the goto statement to jump to that label.
                Syntax:
                    goto label;
                    label:
                        // Code to be executed

            */

            // Example of a for loop
            Console.WriteLine("For Loop Example:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Example of a while loop
            Console.WriteLine("While Loop Example:");
            int j = 0;
            while (j < 5)
            {
                Console.Write(j + " ");
                j++;
            }
            Console.WriteLine();

            // Example of a do-while loop
            Console.WriteLine("Do-While Loop Example:");
            int k = 0;
            do
            {
                Console.Write(k + " ");
                k++;
            } while (k < 5);
            Console.WriteLine();

            // Example of a nested loop
            Console.WriteLine("Nested Loop Example:");
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 2; n++)
                {
                    Console.Write($"({m}, {n}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Example of break statement
            Console.WriteLine("Break Statement Example:");
            for (int p = 0; p < 5; p++)
            {
                if (p == 3)
                {
                    break; // Exit the loop when p equals 3
                }
                Console.Write(p + " ");
            }
            Console.WriteLine();

            // Example of continue statement
            Console.WriteLine("Continue Statement Example:");
            for (int q = 0; q < 5; q++)
            {
                if (q == 2)
                {
                    continue; // Skip the iteration when q equals 2
                }
                Console.Write(q + " ");
            }
            Console.WriteLine();

            // Example of goto statement
            Console.WriteLine("Goto Statement Example:");
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
            goto myLabel;
            Console.WriteLine("Four");
            Console.WriteLine("Five");
            Console.WriteLine("Six");
        myLabel:
            Console.WriteLine("Seven");
            Console.WriteLine("Eight");

            // Forward Jump: Here all the statements after the goto statement will be skipped and control will jump to the label myLabel
            // Backward Jump: Here if we interchange the goto statement and the label, it will create a backward jump, which is not recommended as it can lead to infinite loops or make the code harder to understand. And only for learning we can use the conditionals to see the backward jump.


            // Example of a backward jump (not recommended)
            // Console.WriteLine("Backward Jump Example:");
            // int i = 1;
            // myLabel:
            // Console.WriteLine("This is a backward jump.");
            // i++;
            // if (i < 5) {
               // goto myLabel;
            // }
            // This will create an infinite loop if uncommented
            // Note: The backward jump example is commented out to prevent an infinite loop. It is provided for educational purposes only.


            Console.ReadKey();
        }
    }
}
