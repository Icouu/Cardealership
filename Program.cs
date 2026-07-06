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
        Console.WriteLine("---Добаявне на нов автомобил---");
        string 
            string carId;
    while (true)
    {
        carId = ReadRequiredText("Въведете уникален ID: ");

        if (Cars.Any(c => c.CarId.Equals(carId, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Вече има автомобил с такъв ID. Въведете друг ID.");
        }
        else
        {
            break;
        }
    }

    string make = ReadRequiredText("Въведете марка: ");
    string model = ReadRequiredText("Въведете модел: ");
    int year = ReadInt("Въведете година на производство: ", 1886, DateTime.Now.Year + 1);
    decimal price = ReadDecimal("Въведете цена: ", 0);

    Car newCar = new()
    {
        CarId = carId,
        Make = make,
        Model = model,
        Year = year,
        Price = price,
        Available = true
    };

    Cars.Add(newCar);
    SaveCarsToFile();

    Console.WriteLine("Автомобилът е добавен успешно и е записан във файла.");
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
