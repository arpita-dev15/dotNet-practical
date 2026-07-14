using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();

        while (true)
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Add Course");
            Console.WriteLine("4. View Courses");
            Console.WriteLine("5. Enroll Student in Course");
            Console.WriteLine("6. View Student Details");
            Console.WriteLine("7. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Dept: ");
                    string dept = Console.ReadLine() ?? "";

                    Console.Write("Type (Regular/Scholarship/Part-Time): ");
                    string type = Console.ReadLine() ?? "";

                    students.Add(new Student(id, name, dept, type));
                    break;

                case 2:
                    foreach (var s in students)
                        s.Display();
                    break;

                case 3:
                    Console.Write("Course Id: ");
                    int cid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Course Name: ");
                    string cname = Console.ReadLine() ?? "";

                    Console.Write("Credits: ");
                    int credits = Convert.ToInt32(Console.ReadLine());

                    courses.Add(new Course(cid, cname, credits));
                    break;

                case 4:
                    foreach (var c in courses)
                        Console.WriteLine($"{c.CourseId} - {c.CourseName} ({c.Credits})");
                    break;

                case 5:
                    Console.Write("Enter Student Id: ");
                    int sid = Convert.ToInt32(Console.ReadLine());

                    Student stu = students.Find(s => s.Id == sid);

                    if (stu == null)
                    {
                        Console.WriteLine("Student not found");
                        break;
                    }

                    if (stu.EnrolledCourses.Count >= 5)
                    {
                        Console.WriteLine("Max 5 courses allowed");
                        break;
                    }

                    Console.Write("Enter Course Id: ");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    Course course = courses.Find(c => c.CourseId == courseId);

                    if (course == null)
                    {
                        Console.WriteLine("Course not found");
                        break;
                    }

                    // Prevent duplicate
                    if (stu.EnrolledCourses.Exists(c => c.CourseId == courseId))
                    {
                        Console.WriteLine("Already enrolled!");
                        break;
                    }

                    stu.EnrolledCourses.Add(course);
                    Console.WriteLine("Course enrolled!");
                    break;

                case 6:
                    Console.Write("Enter Student Id: ");
                    int searchId = Convert.ToInt32(Console.ReadLine());

                    Student s1 = students.Find(s => s.Id == searchId);

                    if (s1 != null)
                        s1.Display();
                    else
                        Console.WriteLine("Student not found");
                    break;

                case 7:
                    return;
            }
        }
    }
}