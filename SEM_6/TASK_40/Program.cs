// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// Console.Clear();
// Console.WriteLine("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число C: ");
// int numC = Convert.ToInt32(Console.ReadLine());

Console.Clear();
int A = GetUserInput();
int B = GetUserInput();
int C = GetUserInput();

int GetUserInput()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsRectangle(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B)
    {
        return true;
    }
    return false;
}

if (IsRectangle(A, B, C))
    Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} может существовать");
else
    Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} не может существовать");