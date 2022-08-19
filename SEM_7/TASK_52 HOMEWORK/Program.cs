// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = 3;
int n = 4;
int[,] matrix = new int[m, n];

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

void Average(int[,] matr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double ave = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            ave = ave + matr[j, i];
        }
        ave = ave / m;
        Console.Write($"{ave:F1}; ");
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Average(matrix);