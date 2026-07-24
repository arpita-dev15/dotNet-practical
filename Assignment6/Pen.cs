public class Pen : StationeryItem
{
    public string InkColor { get; set; }
    public string PenType { get; set; }

    public override double CalculateDiscount(double total)
    {
        return total * 0.05;
    }
}