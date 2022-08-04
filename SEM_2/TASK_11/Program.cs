// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
int DeleteSecond(int number)
{
    int firstDigit = number / 100; // 456 -> 4
    int secondDigit = number % 10; // 456 -> 6
    int res = firstDigit * 10 + secondDigit;
    return res;
}
int result = DeleteSecond(num);
Console.WriteLine($"{num} -> {result}");