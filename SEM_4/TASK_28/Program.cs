// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int Factorial(int number)
// {
//     int res = 1;
//     int n = 0;
//     while (n < number)
//     {
//         n++;
//         res = res * n;
//     }
//     return res;
// }

int Factorial(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res = res * i;
    }
    return res;
}

int result = Factorial(num);
Console.WriteLine($"Факториал числа {num} = {result}");