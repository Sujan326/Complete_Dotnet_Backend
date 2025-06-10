using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Operators are the symbol to perform operation.
                -> Operators receive one or more operands but returns a single value.
                -> The different types of operators are:
                    1. Arithmetic Operators:
                        - Used to perform arithmetic operations like addition, subtraction, multiplication, etc.
                        - List of Operators are:
                            + (Addition)
                            - (Subtraction)
                            * (Multiplication)
                            / (Division)
                            % (Modulus)

                    2. Relational Operators:
                        - Used to compare two values.
                        - List of Operators are:
                            == (Equal to)
                            != (Not equal to)
                            > (Greater than)
                            < (Less than)
                            >= (Greater than or equal to)
                            <= (Less than or equal to)

                    3. Logical Operators: 
                        - Used to combine multiple conditions.
                        - List of Operators are:
                            && (Logical AND)
                            || (Logical OR)
                            ! (Logical NOT)

                    4. Assignment Operators:
                        - Used to assign values to variables.
                        - List of Operators are:
                            = (Simple assignment)
                            += (Add and assign)
                            -= (Subtract and assign)
                            *= (Multiply and assign)
                            /= (Divide and assign)
                            %= (Modulus and assign)

                    5. Bitwise Operators: 
                        - Used to perform operations on bits.
                        - List of Operators are:
                            & (Bitwise AND)
                            | (Bitwise OR)
                            ^ (Bitwise XOR)
                            ~ (Bitwise NOT)
                            << (Left shift)
                            >> (Right shift)

                    6. Unary Operators: 
                        - Operate on a single operand.
                        - List of Operators are:
                            ++ (Increment)
                            -- (Decrement)
                            + (Unary plus)
                            - (Unary minus)

                    7. Ternary Operator: 
                        - A shorthand for if-else statements.
                        - Syntax: condition ? value_if_true : value_if_false

                    8. Null Coalescing Operator:
                        - Used to provide a default value when dealing with nullable types.
                        - Syntax: variable ?? default_value
                        - Example: 
                            string name = null;
                            string displayName = name ?? "Default Name";
            */

            // Example for Arithmetic Operators
            int a = 10;
            int b = 5;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: {a + b}");          // 15
            Console.WriteLine($"Subtraction: {a - b}");       // 5
            Console.WriteLine($"Multiplication: {a * b}");    // 50
            Console.WriteLine($"Division: {a / b}");          // 2
            Console.WriteLine($"Modulus: {a % b}");           // 0
            Console.WriteLine();

            // Example for Relational Operators
            Console.WriteLine("Relational Operators:");
            Console.WriteLine($"Equal to: {a == b}");          // False
            Console.WriteLine($"Not equal to: {a != b}");      // True
            Console.WriteLine($"Greater than: {a > b}");       // True
            Console.WriteLine($"Less than: {a < b}");          // False
            Console.WriteLine($"Greater than or equal to: {a >= b}"); // True
            Console.WriteLine($"Less than or equal to: {a <= b}");    // False
            Console.WriteLine();

            // Example for Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("Logical Operators:");
            Console.WriteLine($"Logical AND: {x && y}");      // False
            Console.WriteLine($"Logical OR: {x || y}");       // True
            Console.WriteLine($"Logical NOT: {!x}");          // False
            Console.WriteLine();

            // Example for Assignment Operators
            int c = 20;
            Console.WriteLine("Assignment Operators:");
            c += 5; // c = c + 5
            Console.WriteLine($"Add and assign: {c}");        // 25
            c -= 5; // c = c - 5
            Console.WriteLine($"Subtract and assign: {c}");   // 20
            c *= 2; // c = c * 2
            Console.WriteLine($"Multiply and assign: {c}");   // 40
            c /= 4; // c = c / 4
            Console.WriteLine($"Divide and assign: {c}");     // 10
            c %= 3; // c = c % 3
            Console.WriteLine($"Modulus and assign: {c}");    // 1
            Console.WriteLine();

            // Example for Bitwise Operators
            int d = 6; // 110 in binary
            int e = 3; // 011 in binary
            Console.WriteLine("Bitwise Operators:");
            Console.WriteLine($"Bitwise AND: {d & e}");        // 2 (010 in binary)
            Console.WriteLine($"Bitwise OR: {d | e}");         // 7 (111 in binary)
            Console.WriteLine($"Bitwise XOR: {d ^ e}");        // 5 (101 in binary)
            Console.WriteLine($"Bitwise NOT: {~d}");          // -7 (inverts bits)
            Console.WriteLine($"Left shift: {d << 1}");       // 12 (1100 in binary)
            Console.WriteLine($"Right shift: {d >> 1}");      // 3 (011 in binary)
            Console.WriteLine();

            // Example for Unary Operators
            int f = 5;
            Console.WriteLine("Unary Operators:");
            Console.WriteLine($"Increment: {++f}");          // 6 (pre-increment)
            Console.WriteLine($"Decrement: {--f}");          // 5 (pre-decrement)
            Console.WriteLine($"Unary plus: {+f}");          // 5
            Console.WriteLine($"Unary minus: {-f}");         // -5
            Console.WriteLine();

            // Example for Ternary Operator
            int age = 18;
            string eligibility = (age >= 18) ? "Eligible to vote" : "Not eligible to vote";
            Console.WriteLine("Ternary Operator:");
            Console.WriteLine($"Voting Eligibility: {eligibility}"); // Eligible to vote
            Console.WriteLine();

            // Example for Null Coalescing Operator
            string name = null;
            string displayName = name ?? "Default Name"; // If name is null, use "Default Name"
            Console.WriteLine("Null Coalescing Operator:");
            Console.WriteLine($"Display Name: {displayName}"); // Default Name
            Console.WriteLine();

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
