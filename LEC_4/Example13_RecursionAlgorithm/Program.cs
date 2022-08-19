// Двумерные массивы и рекурсия

Console.Clear();

string[,] table = new string[2, 5]; // new string[строки, столбцы]
// String.Empty - инициализация строк при помощи константы
// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++) // цикл для строк
// {
//     for (int columns = 0; columns < 5; columns++) // вложенный цикл для столбцов
//     {
//         Console.WriteLine($"{table[rows, columns]}");
//     }
// }

// int[,] matrix = new int[3, 4];
// for (int rows = 0; rows < 3; rows++)
// {
//     for (int columns = 0; columns < 4; columns++)
//     {
//         Console.Write($"{matrix[rows, columns]} ");
//     }
//     Console.WriteLine();
// }

// заменяем длину строк и столбцов на автоматическое определение при помощи matrix.GetLength(0) - для строк, и matrix.GetLength(1) - для столбцов

// int[,] matrix = new int[3, 4];
// for (int rows = 0; rows < matrix.GetLength(0); rows++)
// {
//     for (int columns = 0; columns < matrix.GetLength(1); columns++)
//     {
//         Console.Write($"{matrix[rows, columns]} ");
//     }
//     Console.WriteLine();
// }

// метод для печати матрицы и её заполнения числами

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
            matr[i, j] = new Random().Next(1, 10); // [1,10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);