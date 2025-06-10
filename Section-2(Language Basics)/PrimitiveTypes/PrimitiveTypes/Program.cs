using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> The type here specifies what type of value will be stored in the memory. Here type is nothing but the Data Type
                -> The Primitive Types are:
                    - sbyte, byte, short, ushort,i nt, uint, long, ulong, float, double, decimal, char, bool
                    - It strictly stores the single values.
                    - It is the building blocks of Non-Primitive Types.
                
                1. sbyte: Signed Byte
                    - Range: -128 to 127
                    - Size: 1 byte
                    - Default Value: 0

                2. byte: Unsigned Byte (No negative Value)
                    - Range: 0 to 255
                    - Size: 1 byte
                    - Default Value: 0

                3. short: Signed Short Integer
                    - Range: -32,768 to 32,767
                    - Size: 2 bytes
                    - Default Value: 0

                4. ushort: Unsigned Short Integer (No negative Value)
                    - Range: 0 to 65,535
                    - Size: 2 bytes
                    - Default Value: 0

                5. int: Signed Integer
                    - Range: -2,147,483,648 to 2,147,483,647
                    - Size: 4 bytes
                    - Default Value: 0

                6. uint: Unsigned Integer (No negative Value)
                    - Range: 0 to 4,294,967,295
                    - Size: 4 bytes
                    - Default Value: 0

                7. long: Signed Long Integer
                    - Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                    - Size: 8 bytes
                    - Default Value: 0

                8. ulong: Unsigned Long Integer (No negative Value)
                    - Range: 0 to 18,446,744,073,709,551,615
                    - Size: 8 bytes
                    - Default Value: 0

                9. float: Single-Precision Floating Point
                    - Range: Approximately -3.402823E+38 to 3.402823E+38
                    - Size: 4 bytes
                    - Precision: 7 digits
                    - Default Value: 0.0f

                10. double: Double-Precision Floating Point
                    - Range: Approximately -1.79769313486232E+308 to 1.79769313486232E+308
                    - Size: 8 bytes
                    - Precision: 15 digits
                    - Default Value: 0.0d

                11. decimal: High-Precision Decimal
                    - Range: Approximately -7.9228E+28 to 7.9228E+28
                    - Size: 16 bytes
                    - Precision: 28 significant digits
                    - Default Value: 0.0m

                12. char: Character
                    - Represents a single 16-bit Unicode character
                    - Unicode is the superset of ASCII, because ASCII supports only 128 characters (English only), while Unicode supports over 1.1 million characters (many languages).
                    - Size: 2 bytes
                    - Default Value: '\0' (null character)

                13. bool: Boolean
                    - Represents a true or false value
                    - Size: 1 byte
                    - Default Value: false

                NOTE:
                    - In the recent version of C# we can get the default value of the data type using the default keyword.
                    - Example: int defaultValue = default(int); // This will give 0 for int type.

                -> The Non-Primitive Types are:
                    - string, Classes, Interfaces, Structures, Enumerations
                    - Stroes one or more values.
            */

            sbyte a = sbyte.MaxValue;
            byte b = byte.MaxValue;
            short c = short.MaxValue;
            ushort d = ushort.MaxValue;
            int e = int.MaxValue;
            uint f = uint.MaxValue;
            long g = long.MaxValue;
            ulong h = ulong.MaxValue;
            float i = float.MaxValue;
            double j = double.MaxValue;
            decimal k = decimal.MaxValue;
            char l = char.MaxValue; // Represents the last character in Unicode
            bool m = true; // Boolean can be true or false
            string n = "Hello, World!"; // String is a non-primitive type that can hold multiple characters
            Console.WriteLine($"sbyte: {a}");
            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {c}");
            Console.WriteLine($"ushort: {d}");
            Console.WriteLine($"int: {e}");
            Console.WriteLine($"uint: {f}");
            Console.WriteLine($"long: {g}");
            Console.WriteLine($"ulong: {h}");
            Console.WriteLine($"float: {i}");
            Console.WriteLine($"double: {j}");
            Console.WriteLine($"decimal: {k}");
            Console.WriteLine($"char: {l}"); // Displays the last character in Unicode
            Console.WriteLine($"bool: {m}"); // Displays true or false
            Console.WriteLine($"string: {n}"); // Displays the string value
            Console.WriteLine($"Default int value: {default(int)}"); // Displays 0, the default value for int
            Console.WriteLine($"Default bool value: {default(bool)}"); // Displays false, the default value for bool
            Console.WriteLine($"Default char value: '{default(char)}'"); // Displays the null character
            Console.WriteLine($"Default string value: {default(string)}"); // Displays null, the default value for string

            Console.ReadKey();

        }
    }
}
