// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Enter number: ");
string? num = Console.ReadLine();

if (num![0] == num[4])
{
    System.Console.WriteLine(num + " -> да, полиндром");
}
else
{
    System.Console.WriteLine(num + " -> нет, не полиндром");
}

