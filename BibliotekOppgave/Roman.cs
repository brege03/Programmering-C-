using System;

namespace BibliotekOppgave;

public class Roman : Bok
{
    public string Sjanger { get; set; }
    public Roman (string sjanger, int isbn, string tittel, string forfatter, int utgivelsesår) : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Sjanger = sjanger;
    }
    public override void VisInfo()
    {
        Console.WriteLine($"ISBN: {ISBN}, Tittel {Tittel}, Forfatter: {Forfatter}, Utgivelsesår: {Utgivelsesår}, Sjanger: {Sjanger}");
    }
    public void LeverInn()
    {
        Console.WriteLine("Roman er levert inn");
    }
    public void LånUt()
    {
        Console.WriteLine("Roman er lånt ut");
    }

}
