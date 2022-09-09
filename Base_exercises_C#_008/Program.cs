// Напишите программу на C # Sharp, которая принимает число в качестве входных данных, и распечатайте таблицу умножения.

static void MultiplicationTable(int a)
{
    Console.WriteLine($"Таблица умножения для числа {a}: ");
    for (int i = 0; i <=10; i++)
    {
        Console.WriteLine($"{a} * {i} = {a*i}");;
    }
}

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

MultiplicationTable(a);