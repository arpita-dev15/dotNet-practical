//exception handling prevents a program crashing when error occurs
//try - risky code
//catch(Exception e) - handles exception
//finally - always executes

using System;

class Exceptioneg
{
    static void Main()
    {
        try
        {
            int a = 50;
            int b= 3;
            int c = a/b;
            Console.WriteLine(c);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}