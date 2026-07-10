using System;

public class abstracteg : FileStorage
{
    public override void Upload(string filename)
    {
        Console.WriteLine("Upload file to google cloud");
    }
}
