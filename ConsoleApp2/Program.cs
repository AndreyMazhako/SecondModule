using System;

class MainClass
{
    public static void Main()
    {
        string MyName = "Andrey";
        int age = 25;
        bool pet = false;
        double size = 42.5;
        Console.WriteLine("My name is {0}\n" +
            "My age is {1}\n" +
            "Do I have a pet? {2}\n" +
            "My shoe size is {3}", MyName, age, pet, size);
    }
}