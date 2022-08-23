// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

void SearchNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.Write(" -> да");
            return;
        }
    }
    Console.Write(" -> нет");
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

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num}; массив ");
int[] array = CreateArrayRnd(8, 0, 10);
PrintArray(array);
SearchNum(array, num);
