public class Marker : StationeryItem
{
    public bool Permanent { get; set; }

    public override double CalculateDiscount(double total)
    {
        return total * 0.08;
    }
}