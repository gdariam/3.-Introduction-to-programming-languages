// Задача 24: Напишите программу, которая принимает на вход число А и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= num; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int result = GetSum(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");