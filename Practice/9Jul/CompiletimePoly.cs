//suppose an API allows searching in diff ways
//search method is same but parameters will change
//same method, different parameters
//compiler decides which method to call
using System;

class CompiletimePoly
{
    public void Search(int id)
    {
        Console.WriteLine("Search by employee id");
    }

    public void Search(string firstName, string lastName)
    {
        Console.WriteLine("Search by name ");
    }

    public void Search(long phone)
    {
        Console.WriteLine("Search by phone");
    }
}