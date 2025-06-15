using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Static methods are declared using the static keyword/modifier.
                -> The static methods are associated with the class.
                -> Static methods can be called without creating an object of the class.
                -> Static methods are used to manipulate the static fields of the class.
                -> Static methods can be accessed using the class name directly. But if we are calling the static methods or static fields within the same class then no need to use the class name to access them, we can directly access them using there names only.
                -> Static methods cannot access non-static fields or non-static methods directly. They can only access static fields and static methods directly.
                -> But the non-static methods can access both static and non-static fields and methods directly by creating the object of the class.
                -> Static methods cannot use the 'this' keyword because they are not associated with any instance of the class.
             */

            // School Name is not changed
            Student s1 = new Student();
            s1.SetStudentId(101);
            s1.SetStudentName("Sujan");
            Console.WriteLine(s1.ToString());

            // School Name is changed for this, but as it is static, it will be changed for all the instances that is there after this.
            Student s2 = new Student();
            s2.SetStudentId(103);
            s2.SetStudentName("Sita");
            Student.SetSchoolName("SSVM");
            Console.WriteLine(s2.ToString());

            Student s3 = new Student();
            s3.SetStudentId(102);
            s3.SetStudentName("Ramesh");
            Console.WriteLine(s3.ToString());


        }
    }

    public class Student
    {
        public int studentId;
        public string studentName;
        public static string schoolName = "ABC High School";

        // Here using the Non-static or Instance methods to get and set the non-static or instance fields.
        public int GetStudentId()
        {
            return studentId;
        }

        public void SetStudentId(int studentId)
        {
            this.studentId = studentId;
        }

        public string GetStudentName()
        {
            return studentName;
        }

        public  void SetStudentName(string studentName)
        {
            this.studentName = studentName;
        }

        // Here used the static method to get the staic field
        public static string GetSchoolName()
        {
            return schoolName;
        }

        public static void SetSchoolName(string schoolName)
        {
            Student.schoolName = schoolName;
        }

        public string ToString()
        {
            return $"Student ID: {studentId}, Student Name: {studentName}, School Name: {schoolName}";
        }
    }
}
