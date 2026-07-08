//A library stores the names of available books in a list. Display all books,add one new book,
//remove one old book,a nd display the updated list along with the total number of books.
using System;
using System.Reflection.Metadata;
class Library
{
    static void Main()
    {
        List <String>name = new List <String>() {"Pride and Prejudice","Don Quixote","Ideas and Opinions"};
        Console.WriteLine("Original list");
        foreach(String i in name)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Updated list");
        name.Add("The Diary of a young girl");
        name.Remove("Don Quixote");
        foreach(String i in name)
        {
            Console.WriteLine(i);
        }

        

    }
}