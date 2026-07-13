//O - open/closed principle
//software should be open for extension but closed for modification

using System.ComponentModel.DataAnnotations;

class OC
{
    public void Process(Paymentt p)
    {
        p.pay();
    }

    static void Main()
    {
        OC c = new OC();
        c.Process(new CreditCard());
        c.Process(new UIntPtr());

    }
    {
        if(method == "CreditCard")
        {
            Console.WriteLine("Paid using credit");
        }
        else if(method == "UPI")
        {
            Console.WriteLine("Paiusing UPI");
        }

    }
}