using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a number between 1-100 to quit the loop:");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 100)
            {
                break;
            }
            
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}