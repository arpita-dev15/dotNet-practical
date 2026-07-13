using System;

public class Employee
{
    public int Id; 
    public string EmpName;
    public double MonthlySalary;

    public Employee(int i, string e, double s)
    {
        Id = i;
        EmpName = e;
        MonthlySalary = s;
    }

    double CalculateAnnualSalary()
    {
        return MonthlySalary * 12;
    }

    public void Display()
    {
        Console.WriteLine("Id : "+ Id);
        Console.WriteLine("Name : "+EmpName);
        Console.WriteLine("Monthly salary : "+MonthlySalary);
        Console.WriteLine("Annual salary : "+CalculateAnnualSalary());
        Console.WriteLine("----------------------");
    }
}