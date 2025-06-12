using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Constant fields are similar to static fields, means constant fields are also common to all the object of the class created.
                -> But the difference is that constant fields are immutable, means once a constant field is initialized, it cannot be changed.
                -> Constant fields will be replace by the value at compil time, so it will not be stored in memory anywhere.
                -> Constant fields must be initialized at the time of declaration, otherwise it will give compile time error.
                -> Syntax:
                    <access_modifier> const <data_type> <field_name> = <value>;
            */

            // Example of constant field
            Human human1 = new Human();
            human1.Name = "John Doe";
            human1.age = 30;
            Console.WriteLine($"Name: {human1.Name}, Age: {human1.age}, Species: {Human.species}");

        }
    }

    public class Human
    {
        public const string species = "Homo sapiens"; // Constant field, must be initialized at declaration
        public string Name;
        public int age;
    }
}
