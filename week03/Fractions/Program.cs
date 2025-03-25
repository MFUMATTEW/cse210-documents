using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Hold h1 = new Hold(1);
        Hold h2 = new Hold(5);
        Hold h3 = new Hold(3,4);
        Hold h4 = new Hold(1,3);
        
        Console.WriteLine (h1.GetFractionString());
        Console.WriteLine(h1.GetDecimalValue());

        Console.WriteLine(h2.GetFractionString());
        Console.WriteLine(h2.GetDecimalValue());

        Console.WriteLine(h3.GetFractionString());
        Console.WriteLine(h3.GetDecimalValue());

        Console.WriteLine(h4.GetFractionString());
        Console.WriteLine(h4.GetDecimalValue());
        

        
    }
}