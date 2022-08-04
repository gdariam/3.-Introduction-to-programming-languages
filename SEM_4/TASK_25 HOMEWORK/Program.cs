// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

// Решение 1, работает:

Console.WriteLine($"{numA}, {numB} -> {Math.Pow(numA, numB)}");

// Решение 2, работает:

// double Degree(double numberA, double numberB)
// {
//     return Math.Pow(numberA, numberB);
// }
// double res = Degree(numA, numB);
// Console.WriteLine($"{numA}, {numB} -> {res}");

// Решение 3, не работает (почему?):

// int Degree(int numberA, int numberB)
// {
//     int degree = 1;
//     degree = numberA ^ numberB;
//     return degree;
// }
// int res = Degree(numA, numB);
// Console.WriteLine($"{numA}, {numB} -> {res}");