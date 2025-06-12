using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Static fields are stored outside the object, which means that field will be common for all the object that is created.
                -> Static fields are accessble using the className not the objectName.
                -> Static fields are initialized only once, at the start of the program execution.
                -> Syntax: 
                    static <data_type> <field_name>;
            */

            // Example:
            Bank bank1 = new Bank();
            bank1.accountNumber = 1001;
            bank1.accountHolderName = "Sujan";
            Console.WriteLine($"Bank Name: {Bank.bankName}, Account Number: {bank1.accountNumber}, Account Holder Name: {bank1.accountHolderName}");
        }
    }
}
