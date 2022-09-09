// Напишите программу на C # Sharp для вывода результата умножения трех чисел, 
// которые будут введены пользователем.

static void NumbersMultiplication(int a, int b, int c)
{
    Console.WriteLine($"Результат умножения чисел {a} * {b} * {c} = {a*b*c}");
}

Console.Write("Введите первое число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите первое число B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите первое число C: ");
int c = int.Parse(Console.ReadLine());

NumbersMultiplication(a, b, c);
//Console.WriteLine($"Результат умножения чисел {a} * {b} * {c} = {a*b*c}");