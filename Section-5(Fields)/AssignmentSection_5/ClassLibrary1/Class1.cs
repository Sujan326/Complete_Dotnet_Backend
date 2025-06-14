using System;

public class Employee
{
    public int employeeId;
    public string employeeName;
    public double salaryPerHour;
    public int noOfWorkingHours;
    public double netSalary;

    public static string organizationName;
    public const string typeOfEmployee = "Contract Based";
    public readonly string departmentName;

    public Employee()
    {
        departmentName = "Finance Department";
    }

}