using System;
class Dpp
{
    static void Main(string[]args)
    {
        int j=0,k=0,l=0;
        for(int i=1001; i<=1020; i++)
        {
            if(i%4==0)
            {
                j++;
                Console.WriteLine("Quality Check required");
                Console.WriteLine("Number of packages requiring quality check:"+j);
            }
            else if(i%5==0)
            {
                k++;
                Console.WriteLine("Priority Shipment");
                Console.WriteLine("Number of priority shipments"+k);
            }
            else
            {
                l++;
                Console.WriteLine("Normal processing");
                Console.WriteLine("Number of normal packages:");
            }
        }
        Console.WriteLine("Total packages processed:"+(j+k+l));
        
        
        
    }
}