// Задача 26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе:
// 465 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int number)
{
    int index = 1;
    int n = 0;
    while (index <= number)
    {
        n++;
        index = index * 10;
    }
    return n;
}
int res = NumberOfDigits(num);
Console.WriteLine($"Количество цифр в числе: {res}");