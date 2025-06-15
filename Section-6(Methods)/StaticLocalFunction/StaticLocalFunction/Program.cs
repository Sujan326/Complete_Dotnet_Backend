using System;

namespace StaticLocalFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Just like the Local functions where we can write the function inside a method, here we can write the static local function inside a method.
                -> Here the term static is different from the modifier static. 
                -> The only difference here is that Local Functions can access the variables or the parameters of the containing method, But the static local functions does not allow to access the variables or the parameters of containing method so that it is much more stricter which prevents from accidental access of the variables or parameters.
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
            Console.WriteLine($"Marks-1: {marks1}");
            Console.WriteLine($"Marks-2: {marks2}");
            Console.WriteLine($"Marks-3: {marks3}");
            Console.WriteLine($"Average Marks: {averageMarks}");

            static double CalculateAverageMarks(int m1, int m2, int m3) // Here we have to pass the parameters explicitly.
            {
                // Here we cannot access the parameters or variables of the containing method.
                return (m1 + m2 + m3) / 3.0; 
            }
        }
    }


}
