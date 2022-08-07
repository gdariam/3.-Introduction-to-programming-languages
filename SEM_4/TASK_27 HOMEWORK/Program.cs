// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    if (number < 1)
    {
        number = number * -1;
    }
    int sum = 0;
    while (number > 0)
    {
        int n = number % 10;
        number = number / 10;
        sum = sum + n;
    }
    return sum;
}
int res = SumDigits(num);
Console.WriteLine($"{num} -> {res}");