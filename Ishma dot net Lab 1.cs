//Write C# console program to take input from user to print Yourname and print "Welcole Yourname, to dotnet technology"

using System;namespace Lab1Qn1
{
    class Lab1Qn1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
            String name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " to dotnet technology");
            Console.ReadLine();
        }
    }
}