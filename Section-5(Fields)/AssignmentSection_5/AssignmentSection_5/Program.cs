using System;

namespace AssignmentSection_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.employeeId = 101;
            employee1.employeeName = "John Doe";
            employee1.employeeDesignation = "Software Engineer";
            employee1.employeeSalary = 60000;

            employee1.showEmployeeDetails();
            Console.WriteLine();

            Employee employee2 = new Employee();
            employee2.employeeId = 102;
            employee2.employeeName = "Jane Smith";
            employee2.employeeDesignation = "Project Manager";
            employee2.employeeSalary = 80000;

            employee2.showEmployeeDetails();
            Console.WriteLine();

            Employee employee3 = new Employee();
            employee3.employeeId = 103;
            employee3.employeeName = "Alice Johnson";
            employee3.employeeDesignation = "Data Analyst";
            employee3.employeeSalary = 70000;

            employee3.showEmployeeDetails();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
