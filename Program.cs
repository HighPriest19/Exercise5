using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the C# Program! 🎉");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        int squared = number * number;

        Console.WriteLine($"Nice to meet you, {name}!");
        Console.WriteLine($"Did you know that {number} squared is {squared}?");

        Console.WriteLine("Thanks for running your first C# program!");
    }
}