﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] - тип данных, в котором переменная будет массивом в значении типа 'int'
// int[] array = new int[8]{1, 2, 3, 4, 5, 6, 7, 8} - инициализация массива. Новый массив с количеством элементов [8],
// в {} указаны значения, которые будут в массиве; если их не указать, массив по умолчанию заполнится нулями.
// int rndNum = new Random().Next() - заполнение массива псевдослучайными числами; диапазон чисел нужно
// указать в Next(0, 2), при этом, последнее значение не входит в диапазон, т. е. для (0, 2) значения будут 0 и 1.

// Решение общего зала:
// Console.Clear();
// int[] array = new int[8];
// int rndNum = new Random().Next(0, 2);
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if (i == 0) Console.Write("[");
//     Console.Write(array[i] + ",");
//     if (i == 7) Console.Write("]");
// }

// Решение Юрца, по которому тосковал общий зал:

int[] array = GetRandomArray(8);
WriteArrayToConsole(array);

int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

void WriteArrayToConsole(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}