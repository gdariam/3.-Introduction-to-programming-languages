// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(ConvertToBinary(num));

string ConvertToBinary(int num)
{
    string binary = string.Empty;
    while (num >= 1)
    {
        binary += num % 2;
        num /= 2;
    }
    var item = binary.Reverse();
    binary = string.Empty;
    foreach (var i in item)
    {
        binary += i.ToString();
    }
    return binary;
}