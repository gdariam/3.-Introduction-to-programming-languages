﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();

char[] numArray = num.ToCharArray();
if (numArray.Length >= 3)
{
    Console.Write($"{num} -> {numArray[2]}");
}
else
{
    Console.Write($"{num} -> третьей цифры нет");
}