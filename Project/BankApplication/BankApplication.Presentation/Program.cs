using System;
using System.Diagnostics.PerformanceData;

class Program
{
    // Application execution starts here
    static void Main(string[] args)
    {
        // Display Title
        Console.WriteLine("******** Sujan Bank ********");
        Console.WriteLine(":: Login Page ::");

        // Declare the variables to store username and password
        string userName = null;
        string password = null;

        // Read username from keyboard
        Console.Write("Enter the username: ");
        userName = Console.ReadLine();

        // Read password from keyboard only when the user has enterd the username
        if(userName != "")
        {
            Console.Write("Enter the password: ");
            password = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid username or password");
        }

        // Check username and password
        if (userName == "system" && password == "manager")
        {
            // Declare variable to store the main menu choice. Keep the default value -1 meaning user has not entered the choice
            int mainMenuChoice = -1;

            do
            {

                Console.WriteLine("\n::: Main Menu :::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statements");
                Console.WriteLine("5. Account Statements");
                Console.WriteLine("0. Exit");

                Console.Write("Enter the choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (mainMenuChoice != 0);
        }

        // About to exit
        Console.WriteLine("Thank You! Visit Again!");
        Console.ReadKey();
    }

    static void CustomersMenu()
    {
        // Variable to store the user choice
        int customerMenuChoice = -1;

        do
        {
            // display customer menu title
            Console.WriteLine("\n:: Customer Menu ::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("0. Back to Main Menu");

            // Accept the menu choice
            Console.Write("Enter the choice: ");
            customerMenuChoice = int.Parse(Console.ReadLine());

            switch(customerMenuChoice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        } while (customerMenuChoice != 0);
    }

    static void AccountMenu()
    {
        // Variable to store the user choice
        int accountsMenuChoice = -1;

        do
        {
            // display accounts menu title
            Console.WriteLine("\n:: Accounts Menu ::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Accounts");
            Console.WriteLine("0. Back to Main Menu");

            // Accept the menu choice
            Console.Write("Enter the choice: ");
            accountsMenuChoice = int.Parse(Console.ReadLine());

            switch (accountsMenuChoice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        } while (accountsMenuChoice != 0);
    }
}