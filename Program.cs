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

    public static void Main()
    {
        Console.WriteLine("Проект: Управление на автокъща");
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
