using System;

public class Vehicle
{
    public int VehicleId;
    public string VehicleName;
    public string VehicleType;
    public string Brand;
    public decimal Price;
    public int ManYear;

    public Vehicle()
    {
        
    }

    public Vehicle(int i, string n, string t, string b, decimal p, int y)
    {
        VehicleId = i;
        VehicleName = n;
        VehicleType = t;
        Brand = b;
        Price = p;
        ManYear = y;
    }

    public void Display()
    {
   Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("ID    NAME      BRAND      TYPE     PRICE   ");
         Console.WriteLine(""+VehicleId+"      " +VehicleName+"       "+Brand+"      "+VehicleType+"      "+Price);

    }
}