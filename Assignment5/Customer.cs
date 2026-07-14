using System;

public class Customer
{
    public int Id;
    public string Name;
    public string Email;
    public string Password;
    
    public Customer(int i,string n,string e, string p)
    {
        Id = i;
        Name = n;
        Email = e;
        Password = p;
    }
    public void Display()
    {
        Console.WriteLine("Customer Id : "+Id);
        Console.WriteLine("Name : "+Name);
        Console.WriteLine("Email : "+Email);
        Console.WriteLine("Password : " +Password);
    }

    

}
