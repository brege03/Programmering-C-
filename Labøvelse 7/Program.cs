/*using System;
    int tall = 0;
   while(true)
   {
    Console.WriteLine("Skriv inn et tall: ");
    tall = int.Parse(Console.ReadLine());
    string input;

    if(tall > 0)
    {
        Console.WriteLine($"{tall} er positivt");
    }
    else if(tall < 0)
    {
        Console.WriteLine($"{tall} er negativt");
    }
    else
    {
        Console.WriteLine($"{tall} er null");
    }
    
    Console.WriteLine("Sjekke neste tall (ja/nei)");
    input = Console.ReadLine();
    input.ToLower();
    if(input == "nei")
    break;
   }*/

/* int sum = 0;
while (true)
{
 Console.WriteLine("Skriv inn ett tall:");
 int num = int.Parse(Console.ReadLine());
 sum += num;

 if(num == 0)
     break;
}
Console.WriteLine($"Summen er lik: {sum}");*/

/*int num = 0;
Console.WriteLine("Skriv inn et tall: ");
num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
 {
 Console.WriteLine("Tallet er et partall");
 }
 else
 {
 Console.WriteLine("Tallet er et oddetall");
 }*/

/*List<int> list = new List<int>();
int num = 0;

for(int i = 1; i <= 3; i++)
{
    Console.WriteLine("Legg inn et tall: ");
    num = int.Parse(Console.ReadLine());
    list.Add(num);
}

int maxNum = list.Max();
Console.WriteLine($"Det største tallet er {maxNum}!");*/

/*string passord = "";
do
{
    Console.WriteLine("Skriv inn ditt passord: ");
    passord = Console.ReadLine();
}
while(passord != "CSharp123");
    Console.WriteLine("Riktig passord, du blir nå logget inn:)");*/


/*for(int i = 1; i <= 20; i++)
    {
    Console.WriteLine(i);
    }*/
/*int x = 1;
x = x + 1;
x += x;
x++;
++x;*/


class calc
{
    static void Main()
    {
       
        int sum = 0;
        for(int x = 1; x <= 10; sum += x, ++x)
        
        Console.WriteLine($"The sum is: {sum}");

    }
}


