//An automated conveyor belt processes 20 packages. Package IDs are generated from 1001 to 1020 using a loop.
//For each package:
//If the package ID is divisible by 4, it is marked as Quality Check Required.
//Else if the package ID is divisible by 5, it is marked as Priority Shipment.
//Otherwise, it is marked as Normal Processing.
//At the end of the program, display:
//Total packages processed
//Number of packages requiring quality check
//Number of priority shipments
//Number of normal packages

using System;
class Program {
    static void Main(string[]args) {
        Console.WriteLine("--Conveyor started--");
        int total = 0;
        int quality = 0;
        int priority = 0;
        int normal = 0;

        for(int i=1001; i<=1020; i++) {
            total++;
            if(i%4 == 0) {
                quality++;
                Console.WriteLine("Package id "+ i +" Quality check required");
            }
            else if(i%5 == 0) {
                priority++;
                Console.WriteLine("Package id "+ i +" Priority shipment");
            }
            else {
                normal++;
                Console.WriteLine("Package id "+ i +" Normal processing");
            }
        }
        Console.WriteLine("Total pacakages processed : "+total);
        Console.WriteLine("Number of packages requiring quality check : "+ quality);
        Console.WriteLine("Number of priority shipments : "+priority);
        Console.WriteLine("Number of normal packages : "+normal);
    }
}
