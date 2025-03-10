using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();

        Console.WriteLine("What is your name?");
        String name = Console.ReadLine();  

        Console.WriteLine($"Your name is {name}, {first_name} {name}.");
    }
}