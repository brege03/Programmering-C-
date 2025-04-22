using System;

namespace BibliotekOppgave;

//Roman klasse som arver fra Bok klassen
public class Roman : Bok
{
    //Legger til en ny egenskap for sjanger
    public string Sjanger { get; set; }
    //Konstruktør som tar inn sjanger, isbn, tittel, forfatter og utgivelsesår
    public Roman (string sjanger, int isbn, string tittel, string forfatter, int utgivelsesår) : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Sjanger = sjanger;
    }
    //Overstyrer VisInfo metoden fra Bok klassen for å vise informasjon om romanen
    public override void VisInfo()
    {
        Console.WriteLine($"ISBN: {ISBN}, Tittel: {Tittel}, Forfatter: {Forfatter}, Utgivelsesår: {Utgivelsesår}, Sjanger: {Sjanger}");
    }
    //Metode for å levere inn romanen
    public void LeverInn()
    {
        Console.WriteLine($"Roman: {Tittel}, er levert inn");
    }
    //Metode for å låne ut romanen
    public void LånUt()
    {
        Console.WriteLine($"Roman: {Tittel}, er lånt ut");
    }

}
