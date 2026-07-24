using System;


public class InvalidPriceException : Exception { 
    public InvalidPriceException()
        : base("Price must be greater than zero!")
    {
    }}
public class InvalidQuantityException : Exception { public InvalidQuantityException()
        : base("Quantity cannot be negative!")
    {
    }}
public class DuplicateItemException : Exception
{
    public DuplicateItemException()
        : base("Item with same ID already exists!")
    {
    }
}
public class ItemNotFoundException : Exception
{
     public ItemNotFoundException()
        : base("Item not found!")
    {
    }
}
public class InsufficientStockException : Exception
{
    public InsufficientStockException() 
        : base("Not enough stock available!")
    {
    }

    public InsufficientStockException(string message) 
        : base(message)
    {
    }
}
public class LoginFailedException : Exception { 
     public LoginFailedException(string message) : base(message) {}}

public class AppException : Exception
{
    public AppException(string message) : base(message)
    {
    }
}

