int volume = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
double volumeInLiters = volume * 0.001;
double percentage = double.Parse(Console.ReadLine()) / 100;
double neededLiters = volumeInLiters - volumeInLiters * percentage;
Console.WriteLine(neededLiters);
