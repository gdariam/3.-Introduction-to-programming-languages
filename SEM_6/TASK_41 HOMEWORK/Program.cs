// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите количество чисел: ");
int amount = Convert.ToInt32(Console.ReadLine());
int count = 0;

int[] GetUserInput(int amount)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) { count++; }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
}

int[] array = GetUserInput(amount);
PrintArray(array);
Console.Write(" -> ");
Console.Write(count);