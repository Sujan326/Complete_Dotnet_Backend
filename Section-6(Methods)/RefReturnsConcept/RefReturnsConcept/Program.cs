using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefReturnsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Ref returns allow you to return a reference to a variable instead of a copy of its value.
                -> So when you ref return a value, along with the value the reference of that field is also sent, so that the changes that is made at the receiving side will also effect at the sending side.
                -> This is useful when you want to modify the original variable directly without creating a copy.
                -> Syntax: 
                    public ref type MethodName() { ... return ref variable; }
            */

            Student s = new Student();

            // Calling Grade method
            s.Grade();

            // Calling the Do Work Method (RefMethod)
            ref int a = ref s.DoWork();
            Console.WriteLine("Do work method (RefMethod): " + a);

            // Update the value of grade using the ref return
            a = 5;
            Console.WriteLine("Updated value of grade using ref return: " + a);

            // Calling the Grade Method after updating the value
            s.Grade();
        }
    }

    public class Student
    {
        // public field
        public int grade = 2;

        // public method
        public void Grade()
        {
            Console.WriteLine($"Grade: {grade}");
        }

        // public method with ref return
        public ref int DoWork()
        {
            return ref grade;
        }
    }
}
