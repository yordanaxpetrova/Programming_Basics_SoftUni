double nylon = double.Parse(Console.ReadLine()) * 1.50;
double paint = double.Parse(Console.ReadLine()) * 14.50;
double thinner = double.Parse(Console.ReadLine()) * 5.00;
int hours = int.Parse(Console.ReadLine());
double price = nylon + paint + thinner + (paint * 0.10) + 3.00 + 0.40;
double amountPerHour = (price * 0.30) * hours;
Console.WriteLine(amountPerHour + price);