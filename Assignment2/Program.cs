//A company stores the monthly sales of 6 employees in an array.Display all sales,calculate the total sales, average
//sales, highest sales, and lowest sales

using System;
class Sales
{
    static void Main()
    {
        int[] sales = {1000,2000,1500,2500,3000,3500};
        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        for(int i=0; i<6; i++)
        {
            Console.WriteLine("Sales of employee "+ i +": "+sales[i]);
            total += sales[i];

            if (sales[i] > highest)
                highest = sales[i];

            if (sales[i] < lowest)
                lowest = sales[i];
        }
        double average = total / 6.0;

        Console.WriteLine("\nTotal : " + total);
        Console.WriteLine("Average : " + average);
        Console.WriteLine("Highest : " + highest);
        Console.WriteLine("Lowest : " + lowest);

    }
}
