public class Hus
{
    public int AntallRom {get; set;}
    public string Adresse {get; set;} = "";
    public int AntallEtasjer {get; set;}
    public int AntallVegger {get; set;}
    public bool HarTak {get; set;}
    public int ByggÅr {get; set;}

    public bool KlarForSalg()
    {
        bool erKlar = true;

        if(AntallVegger < 4)
        {
            erKlar = false;
        }
        if(AntallRom < 5)
        {
            erKlar = false;
        }
        if(AntallEtasjer < 1)
        {
            erKlar = false;
        }
        if(Adresse == string.Empty)
        {
            erKlar = false;
        }
        if(ByggÅr == 0)
        {
            erKlar = false;
        }
        if(!HarTak)
        {
            erKlar = false;
        }
        return erKlar;
    }
    public void ByggHus(int etasjer, string adresse)
    {
        while(AntallVegger < 4)
        {
            AntallVegger = AntallVegger + 1;
            Console.WriteLine("Vi satt opp en vegg :)");
        }
        while(AntallEtasjer < etasjer)
        {
            AntallEtasjer = AntallEtasjer++;
            Console.WriteLine("vi har satt opp en etasje!");
        }
    }
}

