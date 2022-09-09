// Напишите программу на C # Sharp, чтобы выводить на экран 
//вывод сложения, вычитания, умножения и деления двух чисел, которые будут введены пользователем.

static void Calculation(int a, int b)
{
    Console.WriteLine($"Результат сложения чисел {a} + {b} = {a+b}");
    Console.WriteLine($"Результат вычитания чисел {a} - {b} = {a-b}");
    Console.WriteLine($"Результат умножения чисел {a} * {b} = {a*b}");
    Console.WriteLine($"Результат деления чисел {a} / {b} = {a/b}");
    Console.WriteLine($"Остаток от деления {a} / {b} = {a%b}");
}

Console.Write("Введите первое число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите первое число B: ");
int b = int.Parse(Console.ReadLine());

Calculation(a, b);