class Program
{
    static void Main()
    {
        // Oppretter en ny handlekurv
        Handlekurv handlekurv = new Handlekurv();

        Console.Write("Hvor mange varer vil du legge til? ");
        int antallVarer;

        // Leser inn og validerer antall varer
        while (!int.TryParse(Console.ReadLine(), out antallVarer) || antallVarer <= 0)
        {
            Console.WriteLine("Ugyldig input! Skriv inn et positivt heltall.");
            Console.Write("Hvor mange varer vil du legge til? ");
        }

        // Går gjennom en løkke for å legge til varene i handlekurven
        for (int i = 0; i < antallVarer; i++)
        {
            Console.Write($"Skriv inn prisen for vare {i + 1}: ");
            double pris;

            // Leser inn og validerer prisen på varen
            while (!double.TryParse(Console.ReadLine(), out pris) || pris < 0)
            {
                Console.WriteLine("Ugyldig input! Skriv inn en gyldig pris.");
                Console.Write($"Skriv inn prisen for vare {i + 1}: ");
            }

            // Legger til den gyldige prisen i handlekurven
            handlekurv.LeggTilVare(pris);
        }

        // Skriver ut kvittering for handlekurven
        handlekurv.SkrivKvittering();
    }
}