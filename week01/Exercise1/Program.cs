using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your Last Name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"My Name is {lastName}, {firstName} {lastName}.");
         }



}