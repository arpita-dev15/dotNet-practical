using System;


namespace StationeryStore.Services
{
    public class LoginService
    {
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "admin123";
        public void Login()
        {
            int attempt = 3;
            while(attempt>0)
            {
                Console.WriteLine("Enter Username : ");
                string username = Console.ReadLine() ?? "";

                Console.WriteLine("Enter Password : ");
                string password = Console.ReadLine()?? "";

                if(username == CorrectUsername && password == CorrectPassword)
                {
                    Console.WriteLine("Login successful");
                    return;
                }
                else
                {
                    attempt--;
                    Console.WriteLine("Invalid Login");
                    if(attempt>0)
                    {
                        Console.WriteLine("Attempt left : "+attempt);
                    }
                    else
                    {
                        throw new LoginFailedException("Account locked. Too many Failed attempts!");
                    }
                }
            }
        }
    }
}