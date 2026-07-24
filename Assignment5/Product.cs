using System;
public class Product
{
    public int ProductId;
    public string ProductName;
    public decimal Price;
    public int Stock;

    public Product(int i, string n, decimal p,int s)
    {
        ProductId = i;
        ProductName = n;
        Price = p;
        Stock = s;
    }

    public void Display()
    {
        Console.WriteLine("Product Id : "+ProductId);
        Console.WriteLine("Product Name : "+ProductName);
        Console.WriteLine("Price : "+Price);
        Console.WriteLine("Stock : " +Stock);
    }
}
