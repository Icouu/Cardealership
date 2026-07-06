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
    Console.WriteLine("--- Продажба на автомобил ---");

    string id = ReadRequiredText("Въведете ID на автомобила за продажба: ");

    Car? car = Cars.FirstOrDefault(c => c.CarId.Equals(id, StringComparison.OrdinalIgnoreCase));

    if (car == null)
    {
        Console.WriteLine("Не е намерен автомобил с този ID.");
        return;
    }

    if (!car.Available)
    {
        Console.WriteLine("Този автомобил вече е продаден.");
        return;
    }

    car.Available = false;
    SaveCarsToFile();

    Console.WriteLine("Автомобилът е маркиран като продаден и файлът е актуализиран.");
}
    private static void CheckAvailability()
    {
        private static void CheckAvailability()
{
    Console.WriteLine("--- Проверка на наличност ---");
    Console.WriteLine("Търсене по марка и/или модел. Може да оставите едното поле празно.");

    Console.Write("Марка: ");
    string make = Console.ReadLine()?.Trim() ?? string.Empty;

    Console.Write("Модел: ");
    string model = Console.ReadLine()?.Trim() ?? string.Empty;

    if (string.IsNullOrWhiteSpace(make) && string.IsNullOrWhiteSpace(model))
    {
        Console.WriteLine("Трябва да въведете поне марка или модел.");
        return;
    }

    var foundCars = Cars.Where(c =>
        (string.IsNullOrWhiteSpace(make) || c.Make.Contains(make, StringComparison.OrdinalIgnoreCase)) &&
        (string.IsNullOrWhiteSpace(model) || c.Model.Contains(model, StringComparison.OrdinalIgnoreCase))
    ).ToList();

    if (foundCars.Count == 0)
    {
        Console.WriteLine("Няма намерени автомобили по зададените критерии.");
        return;
    }

    foreach (Car car in foundCars)
    {
        Console.WriteLine(car);
    }
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
