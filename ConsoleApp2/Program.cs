using System;

class Program
{
    static void Main(string[] args)
    {
        (string name, string surname, int age, bool hasPet, int petCount, string[] petNames, int favoriteColorCount, string[] favoriteColors) = GetUserData();

        PrintUserData(name, surname, age, hasPet, petCount, petNames, favoriteColorCount, favoriteColors);
    }

    static (string, string, int, bool, int, string[], int, string[]) GetUserData()
    {
        string name, surname;
        int age, petCount = 0, favoriteColorCount;
        bool hasPet;
        string[] petNames = null;
        string[] favoriteColors = null;

        Console.WriteLine("Введите имя:");
        name = Console.ReadLine();

        Console.WriteLine("Введите фамилию:");
        surname = Console.ReadLine();

        age = GetValidInt("Введите возраст:", 1); 

        Console.WriteLine("Есть ли у вас питомец? (да/нет)");
        hasPet = Console.ReadLine().ToLower() == "да";

        if (hasPet)
        {
            do
            {
                Console.WriteLine("Введите количество питомцев:");
            } while (!int.TryParse(Console.ReadLine(), out petCount) || petCount <= 0);

            petNames = GetPetNames(petCount);
        }
    

        favoriteColorCount = GetValidInt("Введите количество любимых цветов:", 1);

        favoriteColors = GetFavoriteColors(favoriteColorCount);

        return (name, surname, age, hasPet, petCount, petNames, favoriteColorCount, favoriteColors);
    }

    static int GetValidInt(string message, int minValue) 
    {
        int value;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out value) || value <= minValue);
        return value;
    }

    static string[] GetPetNames(int count)
    {
        string[] names = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите кличку питомца {i + 1}:");
            names[i] = Console.ReadLine();
        }
        return names;
    }

    static string[] GetFavoriteColors(int count)
    {
        string[] colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите любимый цвет {i + 1}:");
            colors[i] = Console.ReadLine();
        }
        return colors;
    }

    static void PrintUserData(string name, string surname, int age, bool hasPet, int petCount, string[] petNames, int favoriteColorCount, string[] favoriteColors)
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Наличие питомца: {hasPet}");

        if (hasPet)
        {
            Console.WriteLine($"Количество питомцев: {petCount}");
            Console.WriteLine("Клички питомцев:");
            foreach (string petName in petNames)
            {
                Console.WriteLine(petName);
            }
        }

        Console.WriteLine($"Количество любимых цветов: {favoriteColorCount}");
        Console.WriteLine("Любимые цвета:");
        foreach (string color in favoriteColors)
        {
            Console.WriteLine(color);
        }
    }
}