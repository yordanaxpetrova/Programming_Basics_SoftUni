int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int litersOfDetergent = int.Parse(Console.ReadLine());
int percentageReduction =  int.Parse(Console.ReadLine());
double price = pens * 5.80 + markers * 7.20 + litersOfDetergent * 1.20;
double discountedPrice = price - (price * percentageReduction / 100);
Console.WriteLine(discountedPrice);
