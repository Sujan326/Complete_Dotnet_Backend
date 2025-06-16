using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Recurrsion
{
    internal class Program
    {

        static double Factorial(int number)
        {
            if(number == 0) // Base case defined
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1); // Recursive case defined
            }
        }

        static void Main(string[] args)
        {
            /*
                -> Recursion is a programming technique where a function calls itself to solve a problem.
                -> It is often used to solve problems that can be broken down into smaller, similar subproblems.
                -> A recursive function typically has two main components:
                    1. Base Case: The condition under which the function stops calling itself.
                    2. Recursive Case: The part of the function that calls itself with a modified argument.
                -> Recursion can lead to stack overflow errors if the recursion depth is too high, so it's important to ensure that the base case is reached in a reasonable number of steps.
            */
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = int.Parse(Console.ReadLine());
            double result = Factorial(number);
            Console.WriteLine($"The factorial of {number} is: {result}");
        }
    }
}
