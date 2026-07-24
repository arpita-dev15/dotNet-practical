//LINQ - LAnguage integrated query
//used to query collections like array, list
//where() : filter data, selesct(), orderBy(), orderByDescending()
//first(), count(),min(), max(), sum()

using System;
using System.Linq;

class Linqeg
{
    static void Main()
    {
        int[]numbers = {2,3,4,5,6,7,7,8};
        var even = numbers.Where(x=>x%2==0);

        foreach(var n in even)
        {
            Console.WriteLine(n);
        }
    }
}