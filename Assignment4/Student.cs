using System.Collections.Generic;

public class Student
{
    public int Id;
    public string Name;
    public string Dept;
    public string Type;

    public List<Course> EnrolledCourses = new List<Course>();

    public Student(int id, string name, string dept, string type)
    {
        Id = id;
        Name = name;
        Dept = dept;
        Type = type;
    }

    public void Display()
    {
        Console.WriteLine("Id : "+ Id);
        Console.WriteLine("Name : "+Name);
        Console.WriteLine("Department : "+Dept);
        Console.WriteLine("Type : "+Type);
        Console.WriteLine("----------------------");
    }
}