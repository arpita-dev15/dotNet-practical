//A smart city has 30 street lights numbered 1 to 30. The power consumption (in watts) for each light is calculated using the formula:
//Power = 80 + (Light Number × 5)
//For each street light:
//If power consumption is greater than 180 W, display "Maintenance Required".
//Else if power consumption is between 140 W and 180 W, display "Normal Operation".
//Otherwise, display "Energy Efficient".
//Also calculate and display:
//Total power consumed by all street lights
//Average power consumption
//Number of lights in each category

using System;
using System.ComponentModel.Design;
using System.Globalization;

class Light
{
    static void Main(string[]args)
    {
        int total = 0;
        int maintenance = 0;
        int normal = 0;
        int energy = 0;

        for(int num=1; num<=30; num++)
        {
           int power = 80 + (num*5);
           Console.WriteLine("Light "+num+": "+power+" W");
           if(power>180)
            {
                maintenance++;
                Console.WriteLine("Maintenance required");
            }
            else if(power>=140 && power<=180)
            {
                normal++;
                Console.WriteLine("Normal operation");
            }
            else
            {
                energy++;
                Console.WriteLine("Energy efficient");
            }
            total += power;
        }
        double average = (double)total/ 30;

        Console.WriteLine("\nTotal Power = " + total + " W");
        Console.WriteLine("Average Power = " + average + " W");
        Console.WriteLine("Maintenance = " + maintenance);
        Console.WriteLine("Normal = " + normal);
        Console.WriteLine("Energy Efficient = " + energy);
    }
}