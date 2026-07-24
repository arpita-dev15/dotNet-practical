using System;
using System.Collections.Generic;

//Genericeg<int> n = new Genericeg<int>();
//n.Print(100);

//Genericeg<string> n1 = new Genericeg<string>();
//n1.Print("Amu");

//Genericeg<double> n2 = new Genericeg<double>();
//n2.Print(100.25);

string empName = "ROHAn";
Console.WriteLine(empName.ProperCase());
class Progra
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("\nWelcome to Emp system");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Manager");
            Console.WriteLine("3. View All Employees");
            Console.WriteLine("4. View Managers Only");
            Console.WriteLine("5. Search Employee by id");
            Console.WriteLine("6. Exit");

            Console.Write("Enter a choice 1-6: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;
                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Employee id already exists");
                            break;
                        }

                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter salary: ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Employee employee = new Employee(id, name, salary);
                        employees.Add(employee);

                        Console.WriteLine("Employee added successfully");
                        break;

                    case 2:
                        Console.Write("Enter Manager Id: ");
                        int mid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter name: ");
                        string mname = Console.ReadLine();

                        Console.Write("Enter salary: ");
                        double msalary = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter dept: ");
                        string mdept = Console.ReadLine();

                        Console.Write("Enter bonus: ");
                        double bonus = Convert.ToDouble(Console.ReadLine());

                        Manager manager = new Manager(mid, mname, msalary, mdept, bonus);
                        employees.Add(manager);

                        Console.WriteLine("Manager added successfully");
                        break;

                    case 3:
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No employee in system");
                        }
                        else
                        {
                            foreach (Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }
                        break;

                    case 4:
                        foreach (Employee emp in employees)
                        {
                            if (emp is Manager m)
                            {
                                m.DisplayManager();
                            }
                        }
                        break;

                    case 5:
                        Console.Write("Enter Employee id: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;
                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == searchId)
                            {
                                if (emp is Manager m)
                                    m.DisplayManager();
                                else
                                    emp.Display();

                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}