using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> ReadOnly fields are like instance fields, that is stored in every object individually.
                -> The only difference is ReadOnly fields are immutable means cannot be changed.
                -> ReadOnly fields are accessed using the refernce variable name, means object that is created.
                -> ReadOnly fields can be initialized at the time of declaration or in the constructor.
                -> ReadOnly fields cannot be initialized in the methods.
                -> Syntax:
                       <access_modifier> readonly <data_type> <field_name> = <value>;

                -> We have to use the Static Fields when we want to share the common values across the objects and that value can be changed.(Class Level)
                -> We have to use the Const Fields when we want to share the common values across the objects and that value cannot be changed.(Class Level)
                -> We have to use the ReadOnly Fields when we want to share the common values across the objects and that value can be changed only at the time of declaration or in the constructor.(Instance Level)
            */

            Product p1 = new Product(101);
            p1.productName = "Laptop";
            p1.cost = 50000;
            // p1.productCode = "P-0001"; // This line will cause a compile-time error because productCode is readonly.
            Console.WriteLine($"Product ID: {p1.productId}, Name: {p1.productName}, Cost: {p1.cost}, Code: {p1.productCode}");

            Product p2 = new Product(102);
            p2.productName = "Mobile";
            p2.cost = 20000;
            Console.WriteLine("Product ID: {0}, Name: {1}, Cost: {2}, Code: {3}", p2.productId, p2.productName, p2.cost, p2.productCode);

        }
    }

    public class Product
    {
        public int productId;
        public string productName;
        public double cost;
        public readonly string productCode;

        public Product(int productId)
        {
            this.productId = productId;
            productCode = "P-" + productId;
        }
    }
}
