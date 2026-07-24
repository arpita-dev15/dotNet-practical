public class Notebook : StationeryItem
{
    public int Pages { get; set; }
    public string PaperType { get; set; }

    public override double CalculateDiscount(double total)
    {
        return total * 0.10;
    }
}