using BibliotekOppgave;
using System.Linq;
using System;
using System.Collections.Generic;
internal class Program
{
    static List<Bok> bøker = new List<Bok>();
    
    static void LeggTilBok()
    {
        Console.WriteLine("Hva er ISBN til boken?");
        int isbn = int.Parse(Console.ReadLine());

        Console.WriteLine("Hva er tittelen til boken?");
        string tittel = Console.ReadLine();

        Console.WriteLine("Hva er forfatteren til boken?");
        string forfatter = Console.ReadLine();

        Console.WriteLine("Hva er utgivelsesåret til boken?");
        int utgivelsesår = int.Parse(Console.ReadLine());

        Console.WriteLine("Er boken en fagbok eller en roman?");
        string bokType = Console.ReadLine();
        bokType = bokType.ToLower();

        if(bokType == "roman")
        {
            Console.WriteLine("Hva er sjanger til boken?");
            string sjanger = Console.ReadLine();
            bøker.Add(new Roman(sjanger, isbn, tittel, forfatter, utgivelsesår));
        }

        else if(bokType == "fagbok")
        {
            Console.WriteLine("Hva er fagområdet til boken?");
            string fagområde = Console.ReadLine();
            bøker.Add(new Fagbok(fagområde, isbn, tittel, forfatter, utgivelsesår));
        }

        else
        {
            Console.WriteLine("Ugyldig boktype");
        }
        
    }

    static void ListeOpp()
    {
        foreach(var bok in bøker)
        {
            bok.VisInfo();
        }
    }

    static void FinnForfatter()
    {
        Console.WriteLine("Hva er navnet til forfatteren?");
        string forfatteren = Console.ReadLine();
        var x =
            from bok in bøker
            where bok.Forfatter == forfatteren
            select bok;

        if(!x.Any())
            {
                Console.WriteLine("Fant ingen bøker med denne forfatteren");
            }
            else
            {
                foreach(var bok in x)
                {
                    bok.VisInfo();
                }
            }
    }

    static void FinnÅrstall()
    {
        Console.WriteLine("Hva er årstallet til boken?");
        int år = int.Parse(Console.ReadLine());
        var y =
            from bok in bøker
            where bok.Utgivelsesår == år
            select bok;

        if(!y.Any())
            {
                Console.WriteLine("Fant ingen bøker med dette årstallet");
            }
            else
            {
                foreach(var bok in y)
                {
                    bok.VisInfo();
                }
            }
    }

    static void FinnTittel()
        {
            Console.WriteLine("Hva er tittelen?");
        string tittelen = Console.ReadLine();
        var z =
            from bok in bøker
            where bok.Tittel == tittelen
            select bok;

            if(!z.Any())
            {
                Console.WriteLine("Fant ingen bøker med denne tittelen");
            }
            else
            {
                foreach(var bok in z)
                {
                    bok.VisInfo();
                }
            }
        }


    static void Main(string[] args)
    {
        bøker.Add(new Roman("Fantasy", 123456789, "Harry Potter", "J.K. Rowling", 1997));
        bøker.Add(new Fagbok("Matematikk", 987654321, "Matte 1", "Ola Normann", 2000));
        
        while(true)
        {
        Console.WriteLine("Velkommen til biblioteket");
        Console.WriteLine("[1] Legg til bok");
        Console.WriteLine("[2] Liste opp bøker");
        Console.WriteLine("[3] Finn bok etter forfatter");
        Console.WriteLine("[4] Finn bok etter årstall");
        Console.WriteLine("[5] Finn bok etter tittel");
        Console.WriteLine("[6] Avslutt");
        Console.WriteLine("Velg et alternativ ovenfor: ");

        int valg = int.Parse(Console.ReadLine());

        
            switch(valg)
            {
            case 1:
                LeggTilBok();
                break;
            case 2:
                ListeOpp();
                break;
            case 3:
                FinnForfatter();
                break;
            case 4:
                FinnÅrstall();
                break;
            case 5:
                FinnTittel();
                break;
            case 6:
                Console.WriteLine("Ha en fin dag!");
                return;
            default:
                Console.WriteLine("Ugyldig valg");
                break;
            }
        }
        
    }
}
