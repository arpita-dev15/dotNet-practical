using System;

class Program
{
    static void Main()
    {
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Username: ");
            string user = Console.ReadLine()??"";

            Console.Write("Password: ");
            string pass = Console.ReadLine()??"";

            if (user == "admin" && pass == "123")
            {
                Menu m = new Menu();
                m.Start();
                return;
            }
            else
            {
                attempts--;
                Console.WriteLine("Invalid Login");
            }
        }
       try {
        throw new AppException("Login failed after 3 attempts");
        }
        catch (AppException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        
    }
}