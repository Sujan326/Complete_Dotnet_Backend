using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutConsoleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> The Console class in C# is part of the System namespace and provides methods for input and output operations in a console application.
                -> It allows you to read from and write to the console window, making it essential for console-based applications.
                -> It is a static class so we can use the methods of directly witout creating the object for the Console class. It is a part of BCL.
                -> Members are:
                    1. Write() - Writes the specified data to the console without a new line.
                    2. WriteLine() - Writes the specified data to the console followed by a new line.
                    3. ReadKey() - Reads a single key press from the console and returns it as a ConsoleKeyInfo object.
                    4. Clear() - Clears the console window.
                    5. ReadLine() - Reads a line of input from the console and returns it as a string. If we want numerical value we have to type cast.
             */

            // 1. Prints the message side-by-side
            Console.Write("Welcome");
            Console.Write("To");
            Console.Write("C# Programming");

            // 2. Prints the message line-by-line
            Console.WriteLine("Welcome");
            Console.WriteLine("To");
            Console.WriteLine("C# Programming");

            // 3. Read key to keep the console window open
            Console.ReadKey();

            // 4. Clear the screen
            Console.Clear();
            Console.WriteLine("Thank You");

            Console.ReadKey();
        }
    }
}
