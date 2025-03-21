using System;
using System.Collections.Generic;
using System.Linq;

// Abstrakt klasse Bok
abstract class Bok
{
    public string ISBN { get; set; }
    public string Tittel { get; set; }
    public string Forfatter { get; set; }
    public int Utgivelsesår { get; set; }

    public Bok(string isbn, string tittel, string forfatter, int utgivelsesår)
    {
        ISBN = isbn;
        Tittel = tittel;
        Forfatter = forfatter;
        Utgivelsesår = utgivelsesår;
    }

    public abstract void VisInfo();
}

// Interface IBokFunksjoner
interface IBokFunksjoner
{
    void LånUt();
    void LeverInn();
}

// Subklasse Roman
class Roman : Bok, IBokFunksjoner
{
    public string Sjanger { get; set; }

    public Roman(string isbn, string tittel, string forfatter, int utgivelsesår, string sjanger)
        : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Sjanger = sjanger;
    }

    public override void VisInfo()
    {
        Console.WriteLine($"Roman: {Tittel}, {Forfatter}, {Utgivelsesår}, Sjanger: {Sjanger}");
    }

    public void LånUt()
    {
        Console.WriteLine($"Boken '{Tittel}' er nå lånt ut.");
    }

    public void LeverInn()
    {
        Console.WriteLine($"Boken '{Tittel}' er nå levert tilbake.");
    }
}

// Subklasse Fagbok
class Fagbok : Bok, IBokFunksjoner
{
    public string Fagområde { get; set; }

    public Fagbok(string isbn, string tittel, string forfatter, int utgivelsesår, string fagområde)
        : base(isbn, tittel, forfatter, utgivelsesår)
    {
        Fagområde = fagområde;
    }

    public override void VisInfo()
    {
        Console.WriteLine($"Fagbok: {Tittel}, {Forfatter}, {Utgivelsesår}, Fagområde: {Fagområde}");
    }

    public void LånUt()
    {
        Console.WriteLine($"Boken '{Tittel}' er nå lånt ut.");
    }

    public void LeverInn()
    {
        Console.WriteLine($"Boken '{Tittel}' er nå levert tilbake.");
    }
}

// Hovedprogram
class Program
{
    static List<Bok> bibliotek = new List<Bok>();

    static void Main()
    {
        bool kjører = true;
        while (kjører)
        {
            Console.WriteLine("\nBibliotek meny:");
            Console.WriteLine("1. Legg til bok");
            Console.WriteLine("2. Liste opp bøker");
            Console.WriteLine("3. Søk etter forfatter");
            Console.WriteLine("4. Søk etter utgivelsesår");
            Console.WriteLine("5. Finn bok etter tittel");
            Console.WriteLine("6. Avslutt");
            Console.Write("Velg et alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    LeggTilBok();
                    break;
                case "2":
                    ListeOppBøker();
                    break;
                case "3":
                    SøkEtterForfatter();
                    break;
                case "4":
                    SøkEtterÅr();
                    break;
                case "5":
                    FinnBok();
                    break;
                case "6":
                    kjører = false;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    break;
            }
        }
    }

    static void LeggTilBok()
    {
        Console.Write("Er det en Roman (R) eller Fagbok (F)? ");
        string type = Console.ReadLine()?.ToUpper();

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Tittel: ");
        string tittel = Console.ReadLine();
        Console.Write("Forfatter: ");
        string forfatter = Console.ReadLine();
        Console.Write("Utgivelsesår: ");
        int utgivelsesår = int.Parse(Console.ReadLine());

        if (type == "R")
        {
            Console.Write("Sjanger: ");
            string sjanger = Console.ReadLine();
            bibliotek.Add(new Roman(isbn, tittel, forfatter, utgivelsesår, sjanger));
        }
        else if (type == "F")
        {
            Console.Write("Fagområde: ");
            string fagområde = Console.ReadLine();
            bibliotek.Add(new Fagbok(isbn, tittel, forfatter, utgivelsesår, fagområde));
        }
        else
        {
            Console.WriteLine("Ugyldig valg, prøv igjen.");
        }
    }

    static void ListeOppBøker()
    {
        foreach (var bok in bibliotek)
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterForfatter()
    {
        Console.Write("Skriv inn forfatter: ");
        string forfatter = Console.ReadLine();
        var resultat = bibliotek.Where(b => b.Forfatter.Equals(forfatter, StringComparison.OrdinalIgnoreCase));
        foreach (var bok in resultat)
        {
            bok.VisInfo();
        }
    }

    static void SøkEtterÅr()
    {
        Console.Write("Skriv inn år: ");
        int år = int.Parse(Console.ReadLine());
        var resultat = bibliotek.Where(b => b.Utgivelsesår > år);
        foreach (var bok in resultat)
        {
            bok.VisInfo();
        }
    }

    static void FinnBok()
    {
        Console.Write("Skriv inn tittel: ");
        string tittel = Console.ReadLine();
        var bok = bibliotek.FirstOrDefault(b => b.Tittel.Equals(tittel, StringComparison.OrdinalIgnoreCase));
        if (bok != null)
            bok.VisInfo();
        else
            Console.WriteLine("Bok ikke funnet.");
    }
}
