using System;

namespace BibliotekOppgave;

//Fagbok klasse som arver fra Bok klassen
public class Fagbok : Bok
{
    //Legger til en ny egenskap for fagområde
    public string Fagområde { get; set; }
    //Konstruktør som tar inn fagområde, isbn, tittel, forfatter og utgivelsesår
    public Fagbok (string fagområde, int isbn, string tittel, string forfatter, int utgivelsesår) : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Fagområde = fagområde;
    }
    //Overstyrer VisInfo metoden fra Bok klassen for å vise informasjon om fagboken
    public override void VisInfo()
    {
        Console.WriteLine($"ISBN: {ISBN}, Tittel: {Tittel}, Forfatter: {Forfatter}, Utgivelsesår: {Utgivelsesår}, Fagområde: {Fagområde}");
    }
    //Metode for å levere inn fagboken
    public void LeverInn()
    {
        Console.WriteLine($"Fagboken {Tittel} er levert inn");
    }
    //Metode for å låne ut fagboken
    public void LånUt()
    {
        Console.WriteLine($"Fagboken {Tittel} er lånt ut");
    }
}
