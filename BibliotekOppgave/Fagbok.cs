using System;

namespace BibliotekOppgave;

public class Fagbok : Bok
{
public string Fagområde { get; set; }
    public Fagbok (string fagområde, int isbn, string tittel, string forfatter, int utgivelsesår) : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Fagområde = fagområde;
    }
    public override void VisInfo()
    {
        Console.WriteLine($"ISBN: {ISBN}, Tittel {Tittel}, Forfatter: {Forfatter}, Utgivelsesår: {Utgivelsesår}, Fagområde: {Fagområde}");
    }
    public void LeverInn()
    {
        Console.WriteLine("Fagbok er levert inn");
    }
    public void LånUt()
    {
        Console.WriteLine("Fagbok er lånt ut");
    }
}
