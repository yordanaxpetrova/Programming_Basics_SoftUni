int age = int.Parse(Console.ReadLine());
double washingMachine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());
int money = 0;

for (int birthday = 1; birthday <= age; birthday++)
{
    if (birthday % 2 != 0)
    {
        money += toyPrice;
    }
    else
    {
        money += birthday * 5 - 1;
    }
}

if (money >= washingMachine)
{
    Console.WriteLine($"Yes! {money - washingMachine:F2}");
}
else
{
    Console.WriteLine($"No! {washingMachine - money:F2}");
}