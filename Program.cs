using System.Globalization;

namespace CarDealership;

public class Car
{
    public string CarId { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }

    public override string ToString()
    {
        return "";
    }
    public override string ToString()
    {
        return "";
    }
}

public class Program
{
    private const string FileName = "cars.txt";
    private static readonly List<Car> Cars = new();

    // COMMIT 3 - Main()

public static void Main()
{
    LoadCarsFromFile();

    while (true)
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("     УПРАВЛЕНИЕ НА АВТОКЪЩА");
        Console.WriteLine("=====================================");
        Console.WriteLine("1. Добавяне на нов автомобил");
        Console.WriteLine("2. Продажба на автомобил");
        Console.WriteLine("3. Проверка на наличност");
        Console.WriteLine("4. Справка за всички автомобили");
        Console.WriteLine("0. Изход");
        Console.WriteLine("=====================================");
        Console.Write("Изберете опция: ");

        string? choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                AddCar();
                break;
            case "2":
                SellCar();
                break;
            case "3":
                CheckAvailability();
                break;
            case "4":
                ShowAllCars();
                break;
            case "0":
                SaveCarsToFile();
                Console.WriteLine("Данните са записани. Довиждане!");
                return;
            default:
                Console.WriteLine("Невалиден избор. Опитайте отново.");
                break;
        }

        Pause();
    }
}

    private static void AddCar()
    {
    }

    private static void SellCar()
    {
    }

    private static void CheckAvailability()
    {
    }

    private static void ShowAllCars()
    {
    }

    private static void LoadCarsFromFile()
    {
    }

    private static void SaveCarsToFile()
    {
    }

    private static string ReadRequiredText(string message)
    {
        return "";
    }

    private static int ReadInt(string message, int min, int max)
    {
        return 0;
    }

    private static decimal ReadDecimal(string message, decimal min)
    {
        return 0;
    }

    private static void Pause()
    {
    }
}
