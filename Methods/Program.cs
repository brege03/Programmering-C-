using Methods;

// ny måte å skrive metoder og klasser på, slipper å bruke "sigynsVei." hver linje
RealEstate sigynsVei = new()
{
    Address = "Sigyns Vei",
    SquareMeters = 65,
    Price = 2000000
};

Console.WriteLine(sigynsVei.CalculatePricePerSquareMeters());
