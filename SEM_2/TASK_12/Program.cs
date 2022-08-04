// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int MultipleDigit(int number1, int number2){
    int res = number1 % number2;
    if(res == 0) return 0;
    return res;
}
int result = MultipleDigit(num1, num2);
if(result == 0) Console.WriteLine($"{num1}, {num2} -> Кратно");
else 
Console.WriteLine($"{num1}, {num2} -> Не кратно, остаток {result}");