﻿string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price;

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                price = 2.50;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "apple":
                price = 1.20;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "orange":
                price = 0.85;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "grapefruit":
                price = 1.45;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "kiwi":
                price = 2.70;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "pineapple":
                price = 5.50;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "grapes":
                price = 3.85;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        break;
    case "Saturday":
    case "Sunday":

        switch (fruit)
        {
            case "banana":
                price = 2.70;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "apple":
                price = 1.25;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "orange":
                price = 0.90;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "grapefruit":
                price = 1.60;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "kiwi":
                price = 3.00;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "pineapple":
                price = 5.60;
                Console.WriteLine($"{price * quantity:f2}");
                break;
            case "grapes":
                price = 4.20;
                Console.WriteLine($"{price * quantity:f2}");
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