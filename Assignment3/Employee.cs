using System;
using System.Collections.Generic;

abstract class Employee
{
    public int EmployeeId;
    public string Name;
    public string Department;
    public int LeaveBalance;

    public void DisplayDetails()
    {
        Console.WriteLine("ID: " + EmployeeId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Leave Balance: " + LeaveBalance);
        Console.WriteLine("------------------------");
    }

    public abstract void SetLeaveBalance();
}

class PermanentEmployee : Employee
{
    public override void SetLeaveBalance()
    {
        LeaveBalance = 24;
    }
}

class ContractEmployee : Employee
{
    public override void SetLeaveBalance()
    {
        LeaveBalance = 12;
    }
}

class LeaveRequest
{
    public int LeaveId;
    public int EmployeeId;
    public int NumberOfDays;
    public string Reason;

    public void DisplayLeave()
    {
        Console.WriteLine("Leave ID: " + LeaveId);
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Days: " + NumberOfDays);
        Console.WriteLine("Reason: " + Reason);
        Console.WriteLine("------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Task 1
        List<Employee> employees = new List<Employee>();

        PermanentEmployee e1 = new PermanentEmployee();
        e1.EmployeeId = 101;
        e1.Name = "Anita";
        e1.Department = "HR";
        e1.SetLeaveBalance();

        ContractEmployee e2 = new ContractEmployee();
        e2.EmployeeId = 102;
        e2.Name = "Rahul";
        e2.Department = "IT";
        e2.SetLeaveBalance();

        PermanentEmployee e3 = new PermanentEmployee();
        e3.EmployeeId = 103;
        e3.Name = "Sneha";
        e3.Department = "Finance";
        e3.SetLeaveBalance();

        employees.Add(e1);
        employees.Add(e2);
        employees.Add(e3);

        // Task 2
        Console.WriteLine("All Employees:");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        // Task 3
        List<LeaveRequest> leaves = new List<LeaveRequest>();

        LeaveRequest l1 = new LeaveRequest();
        l1.LeaveId = 1;
        l1.EmployeeId = 101;
        l1.NumberOfDays = 2;
        l1.Reason = "Sick";

        LeaveRequest l2 = new LeaveRequest();
        l2.LeaveId = 2;
        l2.EmployeeId = 103;
        l2.NumberOfDays = 5;
        l2.Reason = "Vacation";

        leaves.Add(l1);
        leaves.Add(l2);

        // Task 4
        Console.WriteLine("Leave Requests:");
        foreach (LeaveRequest lr in leaves)
        {
            lr.DisplayLeave();
        }

        // Task 5
        Console.WriteLine("Permanent Employees:");
        foreach (Employee emp in employees)
        {
            if (emp is PermanentEmployee)
            {
                emp.DisplayDetails();
            }
        }

        // Task 6
        Console.WriteLine("Employee with ID 103:");
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeId == 103)
            {
                emp.DisplayDetails();
            }
        }

        // Task 7
        Console.WriteLine("Total Employees: " + employees.Count);

        // Task 8
        Console.WriteLine("Total Leave Requests: " + leaves.Count);
    }
}