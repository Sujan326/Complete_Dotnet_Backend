using System;

namespace AssignmentSection_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.organizationName = "Harsha Inc.";

            while (true)
            {
                Console.Write("Enter the Employee Id: ");
                int employeeId = int.Parse(Console.ReadLine());

                Console.Write("Enter the Employee Name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Enter the Salary Per Hour: ");
                double salaryPerHour = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of working days: ");
                int numberOfWorkingHours = int.Parse(Console.ReadLine());

                // Creating Object Employee-1:
                Employee e1 = new Employee();
                e1.employeeId = employeeId;
                e1.employeeName = employeeName;
                e1.salaryPerHour = salaryPerHour;
                e1.noOfWorkingHours = numberOfWorkingHours;
                e1.netSalary = e1.salaryPerHour * e1.noOfWorkingHours;

                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine($"Employee Id: {e1.employeeId} | Employee Name: {e1.employeeName} | Salary Per Hour: {e1.salaryPerHour} | Number of Working Days: {e1.noOfWorkingHours} | Net Salary: {e1.netSalary} | Organization Name: {Employee.organizationName} | Type of Employee: {Employee.typeOfEmployee} | Department Name: {e1.departmentName} ");

                Console.Write("Do you want to add employee? (yes/no): ");
                string choice = Console.ReadLine().ToLower();

                if(choice != "yes")
                {
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
