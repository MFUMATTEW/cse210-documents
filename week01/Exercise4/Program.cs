using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        
        int digit = -1;

        while (digit != 0)
        {
            Console.Write("Enter number: ");
            digit = int.Parse(Console.ReadLine());
            numbers.Add(digit);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {((float)sum)/(numbers.Count-1)}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest is:{max}");
    }
}