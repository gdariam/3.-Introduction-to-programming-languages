// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube(int[] num)
{
    int counter = 0;
    int length = num.Length;
    while (counter < length)
    {
        num[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] array = new int[num + 1];
Cube(array);
PrintArray(array);
