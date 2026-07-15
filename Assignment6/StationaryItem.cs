using System;

public abstract class StationeryItem
{
    private double price;
    private int quantity;

    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
                throw new InvalidPriceException();
            price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value <= 0)
                throw new InvalidQuantityException();
            quantity = value;
        }
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"{ItemId} | {ItemName} | {Category} | {Brand} | {Price} | {Quantity}");
    }

    public abstract double CalculateDiscount(double total);
}