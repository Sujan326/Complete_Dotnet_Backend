using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program // Every Application written should be wrapped within the class. The class name can be different from the file name.
    {
        static void Main(string[] args) // Entry point of the Application
        {
            /*
                -> The name of the Main method must be capital 'M'.
                -> The return type of the Main method must be always void(return nothing).
                -> The Main method must be always static, because we can call that method without creating the object of the class.
             */
            System.Console.WriteLine("Hello this is my First Statement in C#");
            System.Console.ReadKey(); // This line is written to keep the console window open
        }
    }
}
