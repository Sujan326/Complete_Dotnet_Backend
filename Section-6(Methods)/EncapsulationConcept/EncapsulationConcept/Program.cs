﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Encapsulation is a fundamental concept in object-oriented programming that restricts direct access to an object's data and methods.
                -> It is like bundling the data fields and methods that manipulate together, in simpler words grouping up the data members and methods.
                -> Hiding the implementation details and exposing only the necessary parts of an object to the outside world.
                -> Benfits:
                    - Modularity: Encapsulation allows you to break down complex systems into smaller, manageable components.
                    - Data Hiding: It restricts access to the internal state of an object, preventing unintended interference and misuse.
                    - Data Integrity: By controlling access to data, encapsulation helps maintain the integrity of an object's state.

            */

            //local constant
            const string developerName = "harsha";

            //create reference variables
            Product product1, product2, product3;

            //create objects
            product1 = new Product();
            Product.TotalNoProducts++; //1
            product2 = new Product();
            Product.TotalNoProducts++; //2
            product3 = new Product();
            Product.TotalNoProducts++; //3

            //initalize fields
            product1.SetProductID(1001);
            product1.SetProductName("Mobile");
            product1.SetCost(20000);
            product1.SetQuantityInStock(1200);
            product2.SetProductID(1003);
            product2.SetProductName("Laptop");
            product2.SetCost(45000);
            product2.SetQuantityInStock(3400);
            product3.SetProductID(1003);
            product3.SetProductName("Speakers");
            product3.SetCost(36000);
            product3.SetQuantityInStock(800);

            //call methods
            product1.CalculateTax();
            product2.CalculateTax();
            product3.CalculateTax();

            //get values from fields
            System.Console.WriteLine(developerName);

            System.Console.WriteLine("Product 1:");
            System.Console.WriteLine("Product ID: " + product1.GetProductID());
            System.Console.WriteLine("Product Name: " + product1.GetProductName());
            System.Console.WriteLine("Cost: " + product1.GetCost());
            System.Console.WriteLine("Quantity in Stock: " + product1.GetQuantityInStock());
            System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
            System.Console.WriteLine("Tax: " + product1.GetTax());

            System.Console.WriteLine("\nProduct 2:");
            System.Console.WriteLine("Product ID: " + product2.GetProductID());
            System.Console.WriteLine("Product Name: " + product2.GetProductName());
            System.Console.WriteLine("Cost: " + product2.GetCost());
            System.Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
            System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
            System.Console.WriteLine("Tax: " + product2.GetTax());

            System.Console.WriteLine("\nProduct 3:");
            System.Console.WriteLine("Product ID: " + product3.GetProductID());
            System.Console.WriteLine("Product Name: " + product3.GetProductName());
            System.Console.WriteLine("Cost: " + product3.GetCost());
            System.Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
            System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
            System.Console.WriteLine("Tax: " + product3.GetTax());

            //total Quantity
            int totalQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();

            //display totals
            System.Console.WriteLine("Total Quantity: " + totalQuantity);
            System.Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);  //Output: 3
            System.Console.WriteLine("Category of products: " + Product.CategoryName);  //Output: Electronics

            System.Console.ReadKey();
        }
    }
}
