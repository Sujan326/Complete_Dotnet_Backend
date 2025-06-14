using System;

public class Employee
{
    public int employeeId;
    public string employeeName;
    public string employeeDesignation;
    public double employeeSalary;

    public void showEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Employee Name: " + employeeName);
        Console.WriteLine("Employee Designation: " + employeeDesignation);
        Console.WriteLine("Employee Salary: " + employeeSalary);
    }

}