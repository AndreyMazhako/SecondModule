using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = (byte)int.Parse(Console.ReadLine());
        Console.Write("When were you born? ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your name is {0} and age is {1}. You were born {2}", name, age, birthdate);
        Console.ReadKey();
    }
}