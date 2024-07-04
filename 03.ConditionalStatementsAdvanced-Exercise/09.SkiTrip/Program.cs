int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string feedback = Console.ReadLine();

double discount = 0.0;
double pricePerNight = 0.0;

switch (roomType)
{
    case "room for one person":
        pricePerNight = 18.00;
        break;
    case "apartment":
        pricePerNight = 25.00;
        break;
    case "president apartment":
        pricePerNight = 35.00;
        break;
}

if (days < 10)
{
    switch (roomType)
    {
        case "apartment":
            discount = 0.30;
            break;
        case "president apartment":
            discount = 0.10;
            break;
    }
}
else if (days >= 10 && days <= 15)
{
    switch (roomType)
    {
        case "apartment":
            discount = 0.35;
            break;
        case "president apartment":
            discount = 0.15;
            break;
    }
}
else
{
    switch (roomType)
    {
        case "apartment":
            discount = 0.50;
            break;
        case "president apartment":
            discount = 0.20;
            break;
    }
}

double totalPrice = (days - 1) * pricePerNight;
totalPrice -= totalPrice * discount;

if (feedback == "positive")
{
    totalPrice += totalPrice * 0.25;
}
else if (feedback == "negative")
{
    totalPrice -= totalPrice * 0.10;
}

Console.WriteLine($"{totalPrice:F2}");