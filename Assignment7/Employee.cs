using System;
using System.Reflection.Metadata;

public class Employee
{
    public int EmpId;
    public string EmpName;
    
    
    public Employee (int i, string n)
    {
        EmpName = n;
        EmpId = i;
    }

    public void Display()
    {
        Console.WriteLine("Welcome " + EmpName);
    }

}