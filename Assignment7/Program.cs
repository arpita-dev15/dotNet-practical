using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections;

class Program
{
static void Main()
{
  List<Employee> employees = new List<Employee>() ;
  List<Vehicle> vehicles = new List<Vehicle>();

    while(true)
    {
        Console.WriteLine("--Welcome--");
        Console.WriteLine("1. User Register");
        Console.WriteLine("2. User login");
        Console.WriteLine("3. Main Menu");
        Console.WriteLine("4. Exit");
        Console.WriteLine("-----------------");

        Console.WriteLine("Enter a choice 1-4");
        try {
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
            case 1:
                Console.WriteLine("Enter User Id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                bool exists = false;
                foreach(Employee emp in employees)
                        {
                            if(emp.EmpId == id)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if(exists)
                        {
                            Console.WriteLine("Employee already exist");
                            break;
                        }
                
                Console.WriteLine("Enter Name : ");
                string name = Console.ReadLine() ?? "";

                Employee employee = new Employee(id, name);
                employees.Add(employee);
                break;

            case 2:
                Console.WriteLine("Enter Id : ");
                int uid = Convert.ToInt32(Console.ReadLine());

                Employee found = null;
                foreach(Employee emp in employees)
                        {
                            if(emp.EmpId == uid)
                            {
                                found = emp;
                                break;
                            }
                        }
                        if (found == null)
                        {
                            Console.WriteLine("Id not registered");
                            break;
                        }
                Console.WriteLine("Welcome "+found.EmpName);
                break;

            case 3:
                while (true) {
                Console.WriteLine("==============================");
                Console.WriteLine("ABC Motors");
                Console.WriteLine("Vehicle Management System");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. View all Vehicles");
                Console.WriteLine("3. Search Vehicle");
                Console.WriteLine("4. Update Vehicle Price");
                Console.WriteLine("5. Delete Vehicle");
                Console.WriteLine("6. Calculate Discount");
                Console.WriteLine("7. Show vehicle Details");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Enter a option between 1-8");

            try
            {
             int option = Convert.ToInt32(Console.ReadLine());

                 switch(option)
                {
                case 1:
                    Console.WriteLine("Enter Vehicle Id :");
                    int vid = Convert.ToInt32(Console.ReadLine());
                    bool exist = false;
                    foreach(Vehicle veh in vehicles)
                    {
                        if(veh.VehicleId == vid)
                        {
                            exist = true;
                            break;
                        }
                    } 
                        if(exist)
                       {
                         Console.WriteLine("Id already exist");
                         break; 
                       }

                        Console.WriteLine("Enter Vehicle Name :");
                        string vname = Console.ReadLine() ?? "";

                         Console.WriteLine("Enter Vehicle Type :");
                        string vtype = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter Brand :");
                        string brand = Console.ReadLine() ?? "";

                         Console.WriteLine("Enter Price :");
                        decimal price = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Manufacturing Year :");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Vehicle vehicle = new Vehicle(vid,vname,vtype,brand,price,year);
                        vehicles.Add(vehicle);
                        break;

                 case 2:
                      if(vehicles.Count == 0)
                      {
                       Console.WriteLine("No vehicle available");
                      }
                      else
                      {
                       foreach(Vehicle veh in vehicles)
                       {
                         veh.Display();
                         Console.WriteLine("----------------------");
                        }
                       }
                        break;

                case 3:
                Console.WriteLine("Enter Vehicle Id");
                int vehid = Convert.ToInt32(Console.ReadLine());
                bool find = false;
                foreach(Vehicle veh in vehicles)
                 {
                    if(veh.VehicleId == vehid)
                    {
                      if (veh is Vehicle v)
                      v.Display();
                      else
                      veh.Display();

                      find = true;
                      break;
                    }
                 }
                    if (!find)
                    {
                         Console.WriteLine("Vehicle not found");
                    }
                break;

                case 4:
                Console.WriteLine("Enter Vehicle Id : ");
                int veid = Convert.ToInt32(Console.ReadLine());
                bool search = false;
                foreach(Vehicle veh in vehicles)
                 {
                    if(veh.VehicleId == veid)
                    {
                      Console.WriteLine("Enter new Price");
                      int Price = Convert.ToInt32(Console.ReadLine());

                      search = true;
                      break;
                    }
                 }
                    if (!search)
                    {
                         Console.WriteLine("Vehicle not found");
                    }

                break;

                case 5:
                Console.Write("\nEnter the Vehicle ID you want to delete: ");
                if (int.TryParse(Console.ReadLine(), out int targetId))
               {
                Vehicle vehicleToDelete = vehicles.FirstOrDefault(v => v.VehicleId == targetId);

                if (vehicleToDelete != null)
               {
        
               Console.Write($"Are you sure you want to delete {vehicleToDelete.VehicleName}? (y/n): ");
               if (Console.ReadLine().ToLower() == "y")
              {
               vehicles.Remove(vehicleToDelete);
               Console.WriteLine("Vehicle deleted successfully.");
              }
              }
             else
            {
              Console.WriteLine("Vehicle ID not found.");
            }
          }
                break;

                case 6:
                Console.WriteLine("\n--- Calculate Discount ---");
                Console.Write("Enter Vehicle ID: ");

                if (int.TryParse(Console.ReadLine(), out int searchId))
                {
                Vehicle targetVehicle = vehicles.FirstOrDefault(v => v.VehicleId == searchId);

                if (targetVehicle != null)
                {
                decimal discountPercentage = 0;
                string type = targetVehicle.VehicleType.ToLower().Trim();

                if (type == "car")
                {
                discountPercentage = 0.10m; 
                }
                else if (type == "bike")
                {
                discountPercentage = 0.05m; // 5%
                }
                else if (type == "truck")
                {
                 discountPercentage = 0.12m; // 12%
                }

                decimal originalPrice = targetVehicle.Price;
                decimal discountAmount = originalPrice * discountPercentage;
                decimal finalPrice = originalPrice - discountAmount;

                Console.WriteLine($"\nVehicle Price : {originalPrice:F0}");
                Console.WriteLine($"Discount      : {discountAmount:F0} ({discountPercentage * 100}%)");
                Console.WriteLine($"Final Price   : {finalPrice:F0}");
                }
                else
                {
                Console.WriteLine("Error: Vehicle ID not found.");
                }
                }
                else
                {
                Console.WriteLine("Error: Invalid ID input.");
                }
                break;

                case 7:
                Console.WriteLine("Enter the vehicle whose details you want to see");
                string vetype = Console.ReadLine() ?? "" ;
                string dtype = vetype.ToLower().Trim();
                switch(vetype.ToLower().Trim()) {
                        case "car" :
                        Console.WriteLine("Car is a four wheeler.");
                        Console.WriteLine("Suitable for family.");
                    break;

                        case "bike":
                        Console.WriteLine("Bike is fuel efficient.");
                        Console.WriteLine("Suitable for city rides.");
                    break;

                        case "truck":
                        Console.WriteLine("Truck is used for transportation.");
                        Console.WriteLine("Heavy load vehicle.");
                    break;

                        default:
                        Console.WriteLine("Unknown vehicle type description.");
                    break;

                }
                break;

                case 8:
                Console.WriteLine("Thank you for using ABC Motor System");
                return;
                }

                    } catch(FormatException)
                            {
                                Console.WriteLine("Please enter a valid Number");
                            }
                    catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                 
                
                }
            case 4:
            return;

            }
            
            }
            catch(FormatException)
            {
              Console.WriteLine("Please enter a valid number");   
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}