using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Bil{
    public Bil()
    {
    }

    public Bil(string merke, string modell, int registreringsår, string registreringsnummer){
        this.Merke= merke;
        Modell = modell;
        registerringsår = registreringsår;
        this.registreringsnummer = registreringsnummer;
    }
    public string Merke {get; set;}
    public string Modell {get; set;}
    public int registerringsår {get; set;}
    public string registreringsnummer {get; set;}
    public int AntallLiterDrivstoff {get; set;} = 10; //satt default verdi med drivstoff
    public bool Kjører(){
        if (AntallLiterDrivstoff > 0){
            AntallLiterDrivstoff--;
            return true;
        }
        else{
            return false;
        }

    }
    
}
 
 