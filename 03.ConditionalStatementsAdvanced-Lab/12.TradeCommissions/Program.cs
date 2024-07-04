string city = Console.ReadLine();
double volumeSales = double.Parse(Console.ReadLine());
double money = 0;

switch (city)
{
    case "Sofia":
        switch (volumeSales)
        {
            case >= 0 and <= 500:
                money = 5;
                break;
            case > 500 and <= 1000:
                money = 7;
                break;
            case > 1000 and <= 10000:
                money = 8;
                break;
            case > 10000:
                money = 12;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    case "Varna":
        switch (volumeSales)
        {
            case >= 0 and <= 500:
                money = 4.5;
                break;
            case > 500 and <= 1000:
                money = 7.5;
                break;
            case > 1000 and <= 10000:
                money = 10;
                break;
            case > 10000:
                money = 13;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    case "Plovdiv":
        switch (volumeSales)
        {
            case >= 0 and <= 500:
                money = 5.5;
                break;
            case > 500 and <= 1000:
                money = 8;
                break;
            case > 1000 and <= 10000:
                money = 12;
                break;
            case > 10000:
                money = 14.5;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    default:
        Console.WriteLine("error");
        break;
}

if (money > 0)
{
    Console.WriteLine($"{(volumeSales * money) / 100:F2}");
}