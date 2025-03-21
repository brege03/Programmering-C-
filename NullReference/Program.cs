//? lar en int være null
int? value = null;

//"! bang operator" kan brukes for å kvitte seg med gule linjer, ? kan også brukes på strings
string? value2 = "null";

//null-checking, returnerer lengden på stringen om den har en verdi
if(value2 is not null)
{
    Console.WriteLine(value2.Length);
}

//null-checking en linje, returnerer "No value" hvis ingen verdi og returnerer string hvis verdi
Console.WriteLine(value2 ?? "No value");

//en linje som sjekker om "value2" har verdi eller ikke, og returnerer svar
Console.WriteLine(value2 is not null ? "Has value" : "No value");


