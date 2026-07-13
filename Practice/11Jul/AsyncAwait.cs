//async - neede for operation which take some time 
//without async , the application waits until the work finishes

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public class AsyncAwait
{
    static async Task Main()
    {
        Console.WriteLine("Loading employee data details....");

        await LoadEmployee();

        Console.WriteLine("Completed");
    }

    static async Task LoadEmployee()
    {
        await Task.Delay(3000);

        Console.WriteLine("Employee loaded");
    }
}