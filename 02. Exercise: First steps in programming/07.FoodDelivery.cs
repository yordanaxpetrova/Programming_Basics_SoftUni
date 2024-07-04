double chickenMenus = double.Parse(Console.ReadLine()) * 10.35;
double fishMenus = double.Parse(Console.ReadLine()) * 12.40;
double vegeterianMenus = double.Parse(Console.ReadLine()) * 8.15;
double menuPrice = chickenMenus + fishMenus + vegeterianMenus;
double dessert = menuPrice * 0.2;
double totalPrice = menuPrice + dessert + 2.50;
Console.WriteLine(totalPrice);
