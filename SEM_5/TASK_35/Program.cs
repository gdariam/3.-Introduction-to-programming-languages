// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int SearchNumbers(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (10 <= array[i] && array[i] <= 99)
        {
            amount = amount + 1;
        }
    }
    return amount;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRnd(123, 0, 150);
PrintArray(array);
Console.Write($" -> {SearchNumbers(array)}");