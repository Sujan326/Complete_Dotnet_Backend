using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiedlsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Reference;
            Product product1, product2, product3;

            // Creating Objects;
            product1 = new Product();
            product2 = new Product();
            product3 = new Product();

            // Initializing Reference
            // It is always a good practice to initialize fields in constructor, but still constructor is not discussed we are doing in this way.
            product1.productId = 1;
            product1.productName = "Vivo";
            product1.cost = 15000.50;
            product1.quantityInStock = 100;

            product2.productId = 2;
            product2.productName = "Dell";
            product2.cost = 50000.75;
            product2.quantityInStock = 50;

            product3.productId = 3;
            product3.productName = "Speaker";
            product3.cost = 1500.00;
            product3.quantityInStock = 200;

            // Printing Values
            Console.WriteLine("Product 1 Details:");
            Console.WriteLine($"Product ID: {product1.productId}");
            Console.WriteLine($"Product Name: {product1.productName}");
            Console.WriteLine($"Cost: {product1.cost}");
            Console.WriteLine($"Quantity in Stock: {product1.quantityInStock}");
            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine($"Product ID: {product2.productId}");
            Console.WriteLine($"Product Name: {product2.productName}");
            Console.WriteLine($"Cost: {product2.cost}");
            Console.WriteLine($"Quantity in Stock: {product2.quantityInStock}");
            Console.WriteLine();

            Console.WriteLine("Product 3 Details:");
            Console.WriteLine($"Product ID: {product3.productId}");
            Console.WriteLine($"Product Name: {product3.productName}");
            Console.WriteLine($"Cost: {product3.cost}");
            Console.WriteLine($"Quantity in Stock: {product3.quantityInStock}");


        }
    }
}
