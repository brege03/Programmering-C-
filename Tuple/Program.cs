using System.Runtime.ExceptionServices;
// basic måte å skrive en tuple på
var values = ("t", 2, "p");

Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);
Console.WriteLine(values.Item3);

//tuple med navn definert
var valuesWithName = (First: "t", Second: 2, Third: "p");

Console.WriteLine(valuesWithName.First);


(int a, string b, bool c) ReturnTheseValues()
{
    return (9, "u", true);
}

(int a, string b, bool c) = ReturnTheseValues();

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
