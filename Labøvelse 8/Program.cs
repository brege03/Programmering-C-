/*using System;  // Importerer System-navneområdet for å bruke Console-klassen

class TwoForLoops
{
    static void Main()
    {
        // Ytre for-løkke: Starter fra 4 og teller ned til 1
        for(int x = 4; x >= 1; --x)
        {
            // Indre for-løkke: Starter fra 5 og teller ned til 1
            for(int y = 5; y >= 1; --y)
            {
                // Skriver ut verdien av y med en tabulator (\t) for mellomrom
                Console.Write($"\t{y}");
            }
            
            // Går til en ny linje etter at den indre løkken er ferdig
            Console.WriteLine();
        }
    }
}*/
/*List<int> list = new List<int>();
int sum = 1;
for(int i = 0; i <= 7; i++)
{
    if(i % 2 == 0)
    {
        continue;
    }
    else
    {
        list.Add(i);
    }
}*/
/*class BreakTest
{
    bool EarlyExit = false;
    static void Main()
    {
        int count;
        for (count = 1; count <= 10; ++count)
        {
            if(count == 5)
            {
                break;
            }
            Console.WriteLine($"{count} ");
        }
        Console.WriteLine($"\nBroke out of loop count = {count}");
    }
}*/


/*int[] g = new int[5];
Array.Fill(g, 8);
foreach(int i in g)
{
    Console.WriteLine(i);
}
float sum = 0;
float[] c = new float[100];
for(int i = 1; i < c.Length; i++)
{
    c[i] = i + 1;
    Console.WriteLine(c[i]);
}
foreach(float value in c)
{
    sum = sum + value;
}
Console.WriteLine($"{sum}");*/