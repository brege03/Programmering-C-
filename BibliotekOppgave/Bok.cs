using System.Linq;
using System;
using System.Collections.Generic;

public abstract class Bok
{
    public int ISBN {get; set; }
    public string Tittel {get; set; }
    public string Forfatter {get; set; }
    public int Utgivelsesår {get; set; }

    public abstract void VisInfo();

    public Bok(int isbn, string tittel, string forfatter, int utgivelsesår)
    {
        ISBN = isbn;
        Tittel = tittel;
        Forfatter = forfatter;
        Utgivelsesår = utgivelsesår;
    }

}
