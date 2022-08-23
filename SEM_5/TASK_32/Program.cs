// Задача 32: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void ReplaceArrayElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
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

int[] array = CreateArrayRnd(6, -10, 10);
PrintArray(array);
Console.Write($" -> ");
ReplaceArrayElements(array);
PrintArray(array);