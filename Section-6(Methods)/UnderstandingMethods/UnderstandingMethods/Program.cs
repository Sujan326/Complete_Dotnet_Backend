using System;

namespace UnderstandingMethods
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
                -> Methods are group of statements that perform specific task based on the fields.
                -> Methods are the part of class.
                -> Methods can receive one more parameters as input and can return a value.
                -> In methods the parameters are optional.
                -> In methods accessModifiers, modifier are also optional.
                -> In order to execute the Method we should call the method after declaring it.
                -> Default access modifiers for methods is Private.
                -> Syntax:
                    accessModifier modifier returnType methodName(parameter1, parameter2,...) 
                    {
                        // method body
                    }
                -> Method Call:
                    methodName();
            */

            //local constant
            const string developerName = "Sujan";

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
            product1.productID = 1001;
            product1.productName = "Mobile";
            product1.cost = 20000;
            product1.quantityInStock = 1200;

            product2.productID = 1003;
            product2.productName = "Laptop";
            product2.cost = 45000;
            product2.quantityInStock = 3400;

            product3.productID = 1003;
            product3.productName = "Speakers";
            product3.cost = 36000;
            product3.quantityInStock = 800;

            // Tax Calculation Method Call
            product1.CalculateTax();
            product2.CalculateTax();
            product3.CalculateTax();

            //get values from fields
            Console.WriteLine(developerName);

            Console.WriteLine("Product 1:");
            Console.WriteLine("Product ID: " + product1.productID);
            Console.WriteLine("Product Name: " + product1.productName);
            Console.WriteLine("Cost: " + product1.cost);
            Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);
            Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);
            Console.WriteLine("Tax: " + product1.tax);

            Console.WriteLine("\nProduct 2:");
            Console.WriteLine("Product ID: " + product2.productID);
            Console.WriteLine("Product Name: " + product2.productName);
            Console.WriteLine("Cost: " + product2.cost);
            Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);
            Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);
            Console.WriteLine("Tax: " + product2.tax);

            Console.WriteLine("\nProduct 3:");
            Console.WriteLine("Product ID: " + product3.productID);
            Console.WriteLine("Product Name: " + product3.productName);
            Console.WriteLine("Cost: " + product3.cost);
            Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);
            Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
            Console.WriteLine("Tax: " + product3.tax);

            int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
            Console.WriteLine("Total Quantity: " + totalQuantity);
            Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);  //Output: 3
            Console.WriteLine("Category of products: " + Product.CategoryName);  //Output: Electronics

            Console.ReadKey();
        }
    }
}
