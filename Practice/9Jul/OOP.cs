using System;

class OOP
{
    static void Main()
    {
        Employee e = new Employee();
        e.empName = "Anita";
        e.salary = 1000;

        Console.WriteLine(e.empName +" "+e.salary);

    }
    // encapsulation : data protection,validation, data controlled

CompiletimePoly c = new CompiletimePoly();
c.Search(101);
c.Search(78945612);
c.Search("Arpita","Mourya");


RuntimePoly r = new RuntimePoly();
r.RuntimePoly(UpiPayment(), 500);
r.RuntimePoly(CreditPayment(), 55000);
r.RuntimePoly(NetBanking(), 25000);


FileStorage s = new FileStorage();
s.Upload("CV.pdf");
s.validateFile();

}