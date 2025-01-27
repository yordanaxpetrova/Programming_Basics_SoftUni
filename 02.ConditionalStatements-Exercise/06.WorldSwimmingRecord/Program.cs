﻿double worldRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timePerMeter = double.Parse(Console.ReadLine());

double recordByIvan = distance * timePerMeter;
double delayTime = Math.Floor(distance / 15) * 12.5;

recordByIvan += delayTime;

double difference = worldRecord - recordByIvan;

if (difference > 0)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower.");
}