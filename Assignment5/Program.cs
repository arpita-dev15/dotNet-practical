//Create a console application for customer registration and login.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>();
        List<Product> products = new List<Product>();
        List<CartItem> cart = new List<CartItem>();

         while(true)
        {
        Console.WriteLine("--WELCOME--");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Add Product");
        Console.WriteLine("4. Display Product");
        Console.WriteLine("5. Search Product");
        Console.WriteLine("6. Add to Cart");
        Console.WriteLine("7. Checkout");
        Console.WriteLine("8. Exit");
        Console.WriteLine("----------------------");
        Console.WriteLine("Enter a choice");

        try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                
             switch(choice) {
                case 1: 
                Console.WriteLine("Enter Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                bool exists = false;
                        foreach (Customer cust in customers)
                        {
                            if (cust.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Customer id already exists");
                            break;
                        }

                Console.WriteLine("Enter Name :");
                string name = Console.ReadLine() ?? "";

                Console.WriteLine("Enter Email :");
                string email = Console.ReadLine() ?? "";

                Console.WriteLine("Enter password :");
                string password = Console.ReadLine() ?? "";

                Customer customer = new Customer(id,name,email,password);
                customers.Add(customer);
                Console.WriteLine("Registration successful!");

                Console.WriteLine("Please enter 2 to Login");

                break;

                case 2 :
                Console.WriteLine("Enter Email : ");
                string cmail = Console.ReadLine()?? "";

                Customer found = null;

                foreach (Customer cust in customers)
                        {
                            if (cust.Email == cmail)
                            {
                                found = cust;
                                break;
                            }
                        }

                        if (found == null)
                        {
                            Console.WriteLine("Email not registered");
                            break;
                        }
                           
                        int attempts = 0;
                        bool loginSuccess = false;

                        while (attempts < 3)
                        {
                            Console.WriteLine("Enter Password : ");
                            string pass = Console.ReadLine() ?? "";

                            if (found.Password == pass)
                            {
                                Console.WriteLine($"Welcome {found.Name}");
                                loginSuccess = true;
                                break;
                            }
                            else
                            {
                                attempts++;
                                Console.WriteLine("Incorrect password");
                            }
                        }
                        if (!loginSuccess)
                        {
                            Console.WriteLine("Account Locked");
                        }
                break;

                case 3 :
                    Console.WriteLine("How many products you want to add?");
                    int count = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < count; i++)
    {
                    Console.WriteLine("Enter Product Id:");
                    int pid = Convert.ToInt32(Console.ReadLine());

                     bool existsProd = false;
                    foreach (Product p in products)
        {
                     if (p.ProductId == pid)
                        {
                            existsProd = true;
                            break;
                        }
        }

                    if (existsProd)
        {
                        Console.WriteLine("Product ID already exists. Try again.");
                        i--;
                        continue;
        }

               Console.WriteLine("Enter Product Name:");
            string pname = Console.ReadLine() ?? "";

             Console.WriteLine("Enter Price:");
             decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Stock:");
            int stock = Convert.ToInt32(Console.ReadLine());

           Product product = new Product(pid, pname, price, stock);
            products.Add(product);
    }

    Console.WriteLine("Products added successfully!");
    break;

                case 4:
    if (products.Count == 0)
    {
        Console.WriteLine("No products available.");
    }
    else
    {
        Console.WriteLine("---- Product List ----");
        foreach (Product prod in products)
        {
            prod.Display();
            Console.WriteLine("-------------------");
        }
    }
    break;

              case 5:
              Console.WriteLine("Enter Product name to search");
              string proName = Console.ReadLine() ?? " " ;

               bool find = false;
                        foreach (Product prod in products)
                        {
                            if (prod.ProductName == proName)
                            {
                                if (prod is Product p)
                                    p.Display();
                                else
                                    prod.Display();

                                find = true;
                                break;
                            }
                        }

                        if (!find)
                        {
                            Console.WriteLine("Product not found");
                        }
                        
              break; 
              case 6:
    if (products.Count == 0)
    {
        Console.WriteLine("No products available.");
        break;
    }

    while (true)
    {
        Console.WriteLine("Enter Product ID:");
        int searchId = Convert.ToInt32(Console.ReadLine());

        Product selected = null;

        foreach (Product p in products)
        {
            if (p.ProductId == searchId)
            {
                selected = p;
                break;
            }
        }

        if (selected == null)
        {
            Console.WriteLine("Product not found");
            continue;
        }

        Console.WriteLine("Enter Quantity:");
        int qty = Convert.ToInt32(Console.ReadLine());

        if (qty <= selected.Stock)
        {
            selected.Stock -= qty;

            cart.Add(new CartItem(selected.ProductName, qty));
            Console.WriteLine("Added to cart!");
        }
        else
        {
            Console.WriteLine("Not enough stock");
        }
        Console.WriteLine("Do you want to add another product : ");
        Console.WriteLine("1. Yes\n2. No");
        int ch = Convert.ToInt32(Console.ReadLine());

        if (ch == 2)
            break;
    }
    break;

              case 7:
    if (cart.Count == 0)
    {
        Console.WriteLine("Cart is empty");
        break;
    }

    decimal total = 0;

    Console.WriteLine("---- Cart ----");

    foreach (CartItem item in cart)
    {
        Console.WriteLine($"{item.ProductName} x{item.Quantity}");

        foreach (Product p in products)
        {
            if (p.ProductName == item.ProductName)
            {
                total += p.Price * item.Quantity;
            }
        }
    }

    Console.WriteLine($"Total Amount: {total}");

    decimal discount = 0;

    if (total >= 10000)
        discount = total * 0.30m;
    else if (total >= 5000)
        discount = total * 0.20m;
    else if (total >= 1000)
        discount = total * 0.10m;

    decimal finalAmount = total - discount;

    Console.WriteLine($"Discount: {discount}");
    Console.WriteLine($"Final Amount: {finalAmount}");

    // Payment
    Console.WriteLine("Choose Payment:");
    Console.WriteLine("1. UPI");
    Console.WriteLine("2. Credit Card");
    Console.WriteLine("3. Debit Card");
    Console.WriteLine("4. Cash on Delivery");

    int pay = Convert.ToInt32(Console.ReadLine());

    switch (pay)
    {
        case 1:
        case 2:
        case 3:
        case 4:
            Console.WriteLine("Payment Successful");
            cart.Clear();
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    break;

                case 8:
                return;

            }
        } catch(FormatException)
            {
                Console.WriteLine("Please enter valid number");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
