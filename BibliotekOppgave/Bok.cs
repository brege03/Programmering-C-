using System.Linq;
using System;
using System.Collections.Generic;

//Abstrakte klasser, base klasse, ment for å arves av andre klasser
public abstract class Bok
{
    public int ISBN {get; set; }
    public string Tittel {get; set; }
    public string Forfatter {get; set; }
    public int Utgivelsesår {get; set; }

    //Metode for å vise informasjon om boken
    public abstract void VisInfo();

    //Konstruktør
    public Bok(int isbn, string tittel, string forfatter, int utgivelsesår)
    {
        ISBN = isbn;
        Tittel = tittel;
        Forfatter = forfatter;
        Utgivelsesår = utgivelsesår;
    }

}
