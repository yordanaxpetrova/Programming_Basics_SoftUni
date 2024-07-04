/*1.Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
2.Брой пъзели - цяло число в интервала [0… 1000]
3.Брой говорещи кукли - цяло число в интервала [0 … 1000]
4.Брой плюшени мечета - цяло число в интервала [0 … 1000]
5.Брой миньони - цяло число в интервала [0 … 1000]
6.Брой камиончета - цяло число в интервала [0 … 1000]*/

double tripPrice = double.Parse(Console.ReadLine());
int numberOfPuzzles = int.Parse(Console.ReadLine());
int numberOfDolls = int.Parse(Console.ReadLine());
int numberOfTeddyBears = int.Parse(Console.ReadLine());
int numberOfMinios = int.Parse(Console.ReadLine());
int numberOfTrucks = int.Parse(Console.ReadLine());

/*•	Пъзел - 2.60 лв.
•	Говореща кукла - 3 лв.
•	Плюшено мече - 4.10 лв.
•	Миньон - 8.20 лв.
•	Камионче - 2 лв.
*/

double sum = numberOfPuzzles * 2.60 + numberOfDolls * 3 + numberOfTeddyBears * 4.10
    + numberOfMinios * 8.20 + numberOfTrucks * 2;

int toys = numberOfPuzzles + numberOfDolls + numberOfTeddyBears + numberOfMinios + numberOfTrucks;

if(toys >= 50)
{
    sum -= sum * 25 / 100;
}
sum -= sum * 10 / 100;

if (sum >= tripPrice)
{
    sum -= tripPrice;
    Console.WriteLine($"Yes! {sum:f2} lv left.");
}
else
{
    tripPrice -= sum;
    Console.WriteLine($"Not enough money! {tripPrice:f2} lv needed.");
}