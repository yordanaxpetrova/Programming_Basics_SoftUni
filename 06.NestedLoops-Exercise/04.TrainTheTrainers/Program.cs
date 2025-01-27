﻿int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
double totalGrade = 0;
int presentationsCount = 0;

while (input != "Finish")
{
    double grade = 0;

    for (int i = 1; i <= n; i++)
    {
        grade += double.Parse(Console.ReadLine());

    }

    Console.WriteLine($"{input} - {grade / n:f2}.");
    presentationsCount++;
    totalGrade += grade / n;

    input = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {totalGrade / presentationsCount:f2}.");