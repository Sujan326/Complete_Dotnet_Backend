using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Local functions are methods defined within another method.
                -> They can access variables from the enclosing method.
                -> Local functions cannot be called outside the method.
                -> Local functions are not the part of the class
                -> Local functions does not suport access modifiers and modifiers.
                -> They cannot be also called using the reference variable of the object.
            */

            Student s = new Student();
            s.DisplayMarks(80, 40, 60);
        }
    }

    class Student
    {
        public void DisplayMarks(int marks1, int marks2, int marks3)
        {
            double averageMarks = CalculateAverageMarks(marks1, marks2, marks3);
            Console.WriteLine($"Marks 1: {marks1}");
            Console.WriteLine($"Marks 2: {marks2}");
            Console.WriteLine($"Marks 3: {marks3}");
            Console.WriteLine($"Average Marks: {averageMarks}");

            // Create Local Function
            double CalculateAverageMarks(int m1, int m2, int m3)
            {
                return (m1 + m2 + m3) / 3.0;
            }
        }
    }
}
