// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int number)
{
    int firstDigit = number % 100;
    int secondDigit = firstDigit / 10;
    return secondDigit;
}
int result = SecondDigit(num);
Console.WriteLine($"{num} -> {result}");