// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.Clear();

int m = 3;
int n = 4;
int[,] matrix = new int[m, n];

int GetUserInput()
{
    Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

bool ElementValues(int A, int B)
{
    if (A <= m && B <= n)
    {
        return true;
    }
    return false;
}

int A = GetUserInput();
int B = GetUserInput();

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

if (ElementValues(A, B))
    Console.WriteLine($"Элемент массива matrix[{A}, {B}] -> {matrix[A - 1, B - 1]}");
else
    Console.WriteLine($"[{A}, {B}] -> такого числа в массиве нет");