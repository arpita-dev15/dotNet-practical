using System;
using System.Collections.Generic;
using System.Linq;

public class Menu : IBill
{
    private List<StationeryItem> items = new List<StationeryItem>();

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine("\n1.Add 2.Display 3.Search 4.Update 5.Delete 6.Purchase 7.LowStock 8.Sort 9.Exit");
            choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1: AddItem(); break;
                    case 2: Display(); break;
                    case 3: Search(); break;
                    case 4: Update(); break;
                    case 5: Delete(); break;
                    case 6: Purchase(); break;
                    case 7: LowStock(); break;
                    case 8: SortMenu(); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.GetType().Name);
            }

        } while (choice != 9);

        Console.WriteLine("Thank You Visit Again");
    }

    // ADD
    private void AddItem()
    {
        Console.WriteLine("Enter Type: 1.Notebook 2.Pen 3.Marker");
        int type = int.Parse(Console.ReadLine());

        StationeryItem item;

        if (type == 1) item = new Notebook();
        else if (type == 2) item = new Pen();
        else item = new Marker();

        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        if (items.Any(x => x.ItemId == id))
            throw new DuplicateItemException();

        item.ItemId = id;

        Console.Write("Name: ");
        item.ItemName = Console.ReadLine();

        Console.Write("Category: ");
        item.Category = Console.ReadLine();

        Console.Write("Brand: ");
        item.Brand = Console.ReadLine();

        Console.Write("Price: ");
        item.Price = double.Parse(Console.ReadLine());

        Console.Write("Quantity: ");
        item.Quantity = int.Parse(Console.ReadLine());

        items.Add(item);
    }

    // DISPLAY
    private void Display()
    {
        foreach (var i in items)
            i.DisplayDetails();
    }

    // SEARCH
    private void Search()
    {
        Console.WriteLine("1.Id 2.Name");
        int ch = int.Parse(Console.ReadLine());

        StationeryItem item = null;

        if (ch == 1)
        {
            int id = int.Parse(Console.ReadLine());
            item = items.FirstOrDefault(x => x.ItemId == id);
        }
        else
        {
            string name = Console.ReadLine();
            item = items.FirstOrDefault(x => x.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        if (item == null)
            throw new ItemNotFoundException();

        item.DisplayDetails();
    }

    // UPDATE
    private void Update()
    {
        int id = int.Parse(Console.ReadLine());

        var item = items.FirstOrDefault(x => x.ItemId == id);

        if (item == null)
            throw new ItemNotFoundException();

        Console.Write("New Price: ");
        item.Price = double.Parse(Console.ReadLine());

        Console.Write("New Quantity: ");
        item.Quantity = int.Parse(Console.ReadLine());

        Console.Write("New Brand: ");
        item.Brand = Console.ReadLine();
    }

    // DELETE
    private void Delete()
    {
        int id = int.Parse(Console.ReadLine());

        var item = items.FirstOrDefault(x => x.ItemId == id);

        if (item == null)
            throw new ItemNotFoundException();

        Console.WriteLine("Delete? Y/N");
        string ch = Console.ReadLine();

        if (ch.ToUpper() == "Y")
            items.Remove(item);
    }

    // PURCHASE
    private void Purchase()
    {
        int id = int.Parse(Console.ReadLine());

        var item = items.FirstOrDefault(x => x.ItemId == id);

        if (item == null)
            throw new ItemNotFoundException();

        int qty = int.Parse(Console.ReadLine());

        if (qty > item.Quantity)
            throw new InsufficientStockException();

        item.Quantity -= qty;

        GenerateBill(item, qty);
    }

    // BILL
    public void GenerateBill(StationeryItem item, int qty)
    {
        double total = item.Price * qty;
        double discount = item.CalculateDiscount(total);
        double gst = total * 0.18;
        double finalAmount = total - discount + gst;

        Console.WriteLine("\n------ BILL ------");
        Console.WriteLine($"Item: {item.ItemName}");
        Console.WriteLine($"Price: {item.Price}");
        Console.WriteLine($"Qty: {qty}");
        Console.WriteLine($"Discount: {discount}");
        Console.WriteLine($"GST: {gst}");
        Console.WriteLine($"Total: {finalAmount}");
        Console.WriteLine("------------------");
    }

    // LOW STOCK
    private void LowStock()
    {
        var low = items.Where(x => x.Quantity < 5);

        foreach (var i in low)
            i.DisplayDetails();
    }

    // SORT
    private void SortMenu()
    {
        Console.WriteLine("1.Price 2.Name 3.Quantity");
        int ch = int.Parse(Console.ReadLine());

        if (ch == 1)
            items = items.OrderBy(x => x.Price).ToList();
        else if (ch == 2)
            items = items.OrderBy(x => x.ItemName).ToList();
        else
            items = items.OrderByDescending(x => x.Quantity).ToList();

        Display();
    }
}