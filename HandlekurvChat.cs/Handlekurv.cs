using System;

public class Handlekurv
{
    // En liste som lagrer prisene på varene i handlekurven
    private List<double> priser = new();
    
    // Metode for å legge til en vare i handlekurven
    public void LeggTilVare(double pris)
    {
        priser.Add(pris); // Legger til prisen i listen
    }
    
    // Metode for å beregne totalprisen på alle varer i handlekurven
    public double BeregnTotal()
    {
        double total = 0;
        foreach (double pris in priser) // Går gjennom alle priser i listen
        {
            total += pris; // Legger hver pris til totalen
        }
        return total; // Returnerer totalprisen
    }
    
    // Metode for å skrive ut kvittering med priser og totalbeløp
    public void SkrivKvittering()
    {
        Console.WriteLine("\n--- KVITTERING ---");
        
        // Skriver ut hver vare med sin pris
        for (int i = 0; i < priser.Count; i++)
        {
            Console.WriteLine($"Vare {i + 1}: {priser[i]:F2} kr"); // F2 formaterer til 2 desimaler
        }
        
        double total = BeregnTotal(); // Beregner totalprisen
        Console.WriteLine($"Totalpris: {total:F2} kr"); // Skriver ut totalprisen
        
        // Hvis totalprisen er over 500 kr, gis gratis frakt
        if (total > 500)
        {
            Console.WriteLine("GRATIS FRAKT inkludert!");
        }

        Console.WriteLine("------------------");
    }
}

