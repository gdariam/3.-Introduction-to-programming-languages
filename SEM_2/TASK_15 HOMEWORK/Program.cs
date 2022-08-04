// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6) {
    Console.WriteLine($"{num} -> Выходной");
} else if (num == 7) {
    Console.WriteLine($"{num} -> Выходной");
} else {
    Console.WriteLine($"{num} -> Этот день не является выходным");
}