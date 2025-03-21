
//Bil minBilFraInput = new Bil(inputArray[0], inputArray[1], int.Parse(inputArray[2]), inputArray[3]);

Bil minBil = new("Volvo", "XC90", 2019, "AB12345");

Bil minAndreBil = new Bil{
    Merke = "Volvo",
    Modell = "v90",
    registerringsår = 2010,
    registreringsnummer = "CD12345" 
};

Bil minTredjeBil =new();
minTredjeBil.Merke = "Volvo";
minTredjeBil.Modell = "XC60";
minTredjeBil.registerringsår = 2015;
minTredjeBil.registreringsnummer = "EF12345";

//løkker
//for løkke, while, do-while, foreach
for (int i = 0; i < 9; i++)
{
    Console.WriteLine(i);
}
//første gang i løkken i = 0, driftoff = 9
//andre gang i løkken i = 1, driftoff = 8
while(minBil.Kjører())
{
    Console.WriteLine($"Bilen {minBil.Merke} {minBil.Modell} kjører");
}
