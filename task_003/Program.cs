﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++)
{
    int result = i * i * i;

    Console.WriteLine(result);
}