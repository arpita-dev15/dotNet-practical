//Collections - Group of objects thay can groe and shrink dynamically
//more flexible than array
//list - dynamic array, automatically inc or decr
//dictionary
using System;
using System.Collections.Generic;
class Collection
{
    static void Main()
    {
        List<string> name = new List<string>();
        name.Add("Arpita");
        name.Add("Krushna");
        name.Add("Payal");
        name.Add("Dhanashri");
        name.Add("Shravani");

        foreach(string f in name)
        {
            Console.WriteLine(f);
        }

        //////////////////////////////////////////////
        /// 
        ///
        /// 
        List<Stud> st = new List<Stud>
        {
            new Stud{id=1, sname = "abc"},
            new Stud{id=2, sname = "cde"},
            new Stud{id=3, sname = "sam"},
            new Stud{id=4, sname = "john"},
        };
        List<Teacher> th = new List<Teacher>
        {
            new Teacher{tid =101, tname = "Mamta"},
            new Teacher{tid = 102, tname = "Anita"},
        };

        foreach(var stu in st)
        {
            Console.WriteLine(stu.id+ " "+ stu.sname);
        }

        foreach(var thu in th)
        {
            Console.WriteLine(thu.tid + " "+ thu.tname);
        }
    }
}
