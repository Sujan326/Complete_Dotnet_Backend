using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Access Modifiers in C# are keywords used to specify the declared accessibility or visibility of a member or a type.
                -> They provide security for the fields.
                -> The main access modifiers in C# are:
                    1. public: The member is accessible from any other code.
                    2. private: The member is accessible only within its own class.
                    3. private protected: The member is accessible within its own class and by derived classes, but only within the same assembly/project.
                    4. protected: The member is accessible within its own class and by derived classes and also in the derived class of other assembly/project.
                    5. internal: The member is accessible only within its own assembly/project.
                    6. protected internal: The member is accessible within its own assembly/project and by derived classes.
                
                Note:
                    - Here the assembly is nothing but the Class Library created and when it is compiler it creates a DLL file which is called as Assembly
            */
        }
    }

    // CHild class at Other Assembly/Project
    public class InternationProducts : Product
    {
        public void Method1()
        {
            productId; // Not Accessible
            productName = "xyz"; // Accessible
            cost = 1; // Not Accessible
            description = "International Product"; // Not Accessible
            manufacturer = "International Manufacturer"; // Accessible
            quantityInStock = 200; // Accessible
        }
    }

    // Other Class at Other Assembly/Project
    public class OtherClass2
    {
        public void Method1()
        {
            Product product1 = new Product();
            product1.productId; // Not Accessible
            product1.productName = "xyz"; // Not Accessible
            product1.cost = 1; // Not Accessible
            product1.description = "International Product"; // Not Accessible
            product1.manufacturer = "International Manufacturer"; // Not Accessible
            product1.quantityInStock = 200; // Accessible
        }
    }
}
