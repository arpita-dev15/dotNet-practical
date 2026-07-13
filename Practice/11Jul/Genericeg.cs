class Genericeg
{
    void Printt(int number)
    {
        Console.WriteLine(number);
    }

    void Printt(string namee)
    {
        Console.WriteLine(namee);
    }
}

//generics - write one class or method that work with diff data type without duplicate code
class Genericseg<T>
{
    void Print(T value)
    {
        Console.WriteLine(value);
    }
}