using System;

class Program
{
    static void Main()
    {
        Console.Write("your birth year ");
        int birthYear = int.Parse(Console.ReadLine());

        int age = DateTime.Now.Year - birthYear;

        Console.WriteLine("your age " + age);
    }
}
