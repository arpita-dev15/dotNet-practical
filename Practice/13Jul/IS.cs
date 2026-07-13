//I - Interface Segregation Principle 
//clients should not be forced to implement methods they do not use
//they do not use

interface Program
{
    void work();
    void walk();
    void eat();
}

class Human : Program
{
    public void work()
    {
        
    }
    public void walk() { }
    public void eat() { }
}

class Robot : Program
{
    public void work() { }
    public void walk() { }
    public void eat() { }
}