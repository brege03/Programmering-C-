using System;

public class Student
{
    private string Navn;
    private int Alder;
    private double Gjennomsnittskarakter;

    public void SkrivInfo()
    {
        // Be om navn
        Console.Write("Skriv inn navn: ");
        Navn = Console.ReadLine() ?? "Ukjent";

        // Be om alder med validering
        while (true)
        {
            Console.Write("Skriv inn alder: ");
            if (int.TryParse(Console.ReadLine(), out Alder) && Alder > 0)
            {
                break;
            }
            Console.WriteLine("Ugyldig input! Vennligst skriv inn et gyldig tall for alder.");
        }

        // Be om gjennomsnittskarakter med validering
        while (true)
        {
            Console.Write("Skriv inn gjennomsnittskarakter: ");
            if (double.TryParse(Console.ReadLine(), out Gjennomsnittskarakter) && 
                Gjennomsnittskarakter >= 0 && Gjennomsnittskarakter <= 6)
            {
                break;
            }
            Console.WriteLine("Ugyldig input! Gjennomsnittskarakter må være mellom 0 og 6.");
        }

        // Vis informasjon
        Console.WriteLine("Studentinformasjon:");
        Console.WriteLine($"Navn: {Navn}");
        Console.WriteLine($"Alder: {Alder}");
        Console.WriteLine($"Gjennomsnittskarakter: {Gjennomsnittskarakter}");
    }
    public void HarBestått()
    {
        if(Gjennomsnittskarakter >= 5)
        {
            Console.WriteLine("Du har bestått:)");
        }
        else if(Gjennomsnittskarakter < 5)
        {
            Console.WriteLine("Du har ikke bestått:(");
        }
    }
    public void ForventetKarakterEtterXÅr()
    {
        double forbedring;
        int xÅr = 2;
        forbedring = Gjennomsnittskarakter + (1.0 * xÅr);

        Console.WriteLine($"Forventet karakter etter 2 år er {forbedring}");
    }

    public void Betingelser()
    {
        if(Alder >= 18 && Gjennomsnittskarakter >= 5.0)
        {
            Console.WriteLine($"{Navn} er 18 år eller eldre og har en gjennonmsnittskarakter på 5.0 eller høyere.");
        }
        else if(Alder < 18 || Navn.StartsWith('S'))
        {
            Console.WriteLine($"{Navn} er enten under 18 år eller navnet starter med 'S'.");
        }
        else if(Alder < 18 || Navn.StartsWith('s'))
        {
            Console.WriteLine($"{Navn} er enten under 18 år eller navnet starter med 's'.");
        }
        else
        {
            Console.WriteLine("Ingen betingelser funnet");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.SkrivInfo();
        student1.HarBestått();
        student1.ForventetKarakterEtterXÅr();
        student1.Betingelser();
    }
}