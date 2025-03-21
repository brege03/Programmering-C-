public class Asset
{
    public string Name { get; set; }
    private decimal _assetValue;
    private decimal _assetDepreciation;

    public Asset(string assetName, decimal assetValue, decimal assetDepreciation)
    {
        Name = assetName;
        AssetValue = assetValue;
        AssetDepreciation = assetDepreciation;
    }

    public decimal AssetValue
    {
        get {return _assetValue; }
        set
        {
            if(value < 0)
            {
                _assetValue = 0.0m;
            }
            else
            {
                _assetValue = value;
            }
        }

    }
    public decimal AssetDepreciation

    {
        get {return _assetDepreciation; }
        set
        {
            if(value < 0)
            {
                _assetDepreciation = 0.0m;
            }
            else
            {
                _assetDepreciation = value;
            }
        }

    }

    
}


class Program
{
    static void Main()
    {
        Asset asset1 = new("Brage", 45.00m, 5.00m);
        Asset asset2 = new("Oliver", 56.00m, 5.00m);


    }
}