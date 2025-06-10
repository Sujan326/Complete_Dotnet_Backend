using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsSection2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Area of a Circle  
            Console.WriteLine("Area of Circle");
            double radius = 5; // We change this value as needed  
            double pi = 3.14159;
            double area = pi * radius * radius;
            Console.WriteLine($"The area of the circle with radius {radius} is {area}");

            Console.WriteLine();

            // 2. Write a C# program convert a person's height (in feet and inches) to centimeters.  
            Console.WriteLine("Height Conversion to Centimeters");
            double feet = 5;
            double inch = 7;
            double totalInches = (feet * 12) + inch;
            double cms = totalInches * 2.54;

            Console.WriteLine($"Height in cms is: {cms}");

            Console.WriteLine();

            // 3. Write a C# program to get nearest thousand of given integer number. Here, let name the input value as "number".  
            Console.WriteLine("Nearest Thousand Calculation");
            int number = 1500;
            int baseValue = (number / 1000) * 1000;
            int remainder = number % 1000;

            //Console.WriteLine($"number / 1000: {number / 1000}");  // DEBUGGING LINES FOR BETTER UNDERSTANDING
            //Console.WriteLine($"Base number is: {baseValue} \nand Remainder is: {remainder}");  // DEBUGGING LINES FOR BETTER UNDERSTANDING

            int nearestThousand = (remainder >= 500) ? (baseValue + 1000) : baseValue;
            Console.WriteLine($"Nearest thousand of {number} is: {nearestThousand}");

            Console.WriteLine();

            // 4. Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
            Console.WriteLine("Time Conversion from Seconds");
            // Total number of seconds to convert
            int totalSeconds = 288970;

            // Calculate number of full days
            // 1 day = 86400 seconds
            int days = totalSeconds / 86400;

            // Calculate remaining hours after removing full days
            // First, get the leftover seconds after days using modulus (%)
            // Then divide by 3600 (1 hour = 3600 seconds)
            int hours = (totalSeconds % 86400) / 3600;

            // Calculate remaining minutes after removing full hours
            // Use modulus with 3600 to get leftover seconds after full hours
            // Then divide by 60 (1 minute = 60 seconds)
            int minutes = (totalSeconds % 3600) / 60;

            // Calculate remaining seconds after full minutes
            // Use modulus with 60 to get leftover seconds
            int seconds = totalSeconds % 60;

            // Final Output
            Console.WriteLine($"{days} days, {hours} hours, {minutes} minutes, {seconds} seconds");

            Console.WriteLine();

            // 5. Height Cheker
            Console.WriteLine("Height Checker");
            double heightInInch = 75;
            double centimeters = heightInInch * 2.54;

            if (centimeters < 150)
            {
                Console.WriteLine("Dwarft");
            }
            else if (centimeters >= 150 && centimeters < 165)
            {
                Console.WriteLine("Average Height");
            }
            else if (centimeters >= 165 && centimeters < 195)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal Height");
            }

            Console.WriteLine();

            // 6. Largest of Three Numbers
            Console.WriteLine("Largest of Three Numbers");
            int num1 = 60, num2 = 45, num3 = 123;

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if(num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }

            Console.ReadKey();
        }
    }
}
