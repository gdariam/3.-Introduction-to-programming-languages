// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    int index = 1;
    int n = 1;
    int sum = 0;
    while (index <= number)
    {
        // n++;
        index = index * 10;
        sum = sum + 0;
    }
    return sum;
}
int res = SumDigits(num);
Console.WriteLine($"{num} -> {res}");