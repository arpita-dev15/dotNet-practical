//Serialization - converts an object into a format(JSON) so it can be saved and shared over a network

using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

class SerializeEg
{
    static void main()
    {
        Employee e = new Employee(101,"abc",4500);
        string json = JsonSerializer.Serialize(e);
        Console.WriteLine(json);

        //{101, abc, 4500}

        //deserialize 
        Employee e1 = JsonSerializer.Deserialize<Employee>(json);
        Console.WriteLine(e1.EmpName);
    }
}