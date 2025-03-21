using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    private decimal monthlySalary;
   
    public Employee(string firstName, string lastName, decimal monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary;
    }
   
    public decimal MonthlySalary
    {
        get
        {
            return monthlySalary;
        }
        set
        {
            if(value >= 0M)
            {
                monthlySalary = value;
            }
        }
    }
   
    public override string ToString() =>
        $"{FirstName, -10} {LastName, -10} {MonthlySalary, 10:C}";
}
 
class LINQWithArrayOfObjects
{
    static void Main()
    {
        var employees = new[] {
            new Employee("Per", "Ingebritsen", 5000M),
            new Employee("John", "MacLongcock", 10000M),
            new Employee("Mister", "Fister", 3M),
            new Employee("Cheif", "Queef", 4550M),
            new Employee("Nilus", "Langballe", 3500M)};
       
        Console.WriteLine("Original array:");
        {
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }
        }
       
        var between4k6k =
            from e in employees
            where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
            select e;
       
        Console.WriteLine("\nEmployees earning in the range" + $"{4000:C}-{6000:C} per month:");
        foreach (var element in between4k6k)
        {
            Console.WriteLine(element);
        }
       
        var nameSorted =
            from e in employees
            orderby e.LastName, e.FirstName
            select e;
       
        Console.WriteLine("\nFirst employee when sorted by name:");
       
        if(nameSorted.Any())
        {
            Console.WriteLine(nameSorted.First());
        }
        else
        {
            Console.WriteLine("not found");
        }
       
        var lastNames =
            from e in employees
            select e.LastName;
       
        Console.WriteLine("\nUnique employee last names:");
        foreach(var element in lastNames.Distinct())
        {
            Console.WriteLine(element);
        }
       
        var names =
            from e in employees
            select new {e.FirstName, e.LastName};
           
        Console.WriteLine("\nNames only:");
        foreach (var element in names)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine();
    }
}