//L - Liskov Substitution Principle
//a derived class should be able to replace its base class
//without changing program's correctness

class Bird
{
    public void Fly()
    {
        Console.WriteLine("Flyingg");
    }
}

class Penguin : Bird
{
    public override void Fly()
    {
        throw new Exception("can;t fly");
    }
}