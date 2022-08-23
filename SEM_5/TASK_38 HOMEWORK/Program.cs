// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateArrayRnd(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min);
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]:F1}, ");
        else Console.Write($"{array[i]:F1}]");
    }
}

double Difference(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
        else if (array[i] > max) { max = array[i]; }
    }
    return diff = max - min;
}


double[] array = CreateArrayRnd(5, 0, 10);
PrintArray(array);
Console.Write(" -> ");
double difference = Difference(array);
Console.Write($"{difference:F1}");