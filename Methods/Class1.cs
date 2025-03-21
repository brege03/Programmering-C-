using System;

namespace Methods
{
    public class RealEstate
{
    public string Address { get; set; }
    public int Price { get; set; }
    public int SquareMeters { get; set; }
    public int CalculatePricePerSquareMeters() => Price / SquareMeters;
}
}
