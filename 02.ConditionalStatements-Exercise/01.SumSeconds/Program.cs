﻿int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());
int totalTime = first + second + third;
int min = totalTime / 60;
int sec = totalTime % 60;
Console.WriteLine($"{min}:{sec:d2}");