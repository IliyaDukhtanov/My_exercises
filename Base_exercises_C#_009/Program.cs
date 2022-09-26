using System.Collections.Generic;

// Напишите программу на C # Sharp, 
// которая использует четыре числа в качестве входных данных для вычисления и печати среднего значения.

// Console.Write("Введите число A: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число B: ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число C: ");
// double c = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число D: ");
// double d = Convert.ToDouble(Console.ReadLine());

// double avg = (a + b + c +d)/4;
// Console.WriteLine($"Среднее арифметическое введённых чисел равно {avg}");

void Average(List<int> numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        sum += numbers[i];
    }
    double avg = sum/numbers.Count;
    Console.WriteLine($"Среднее арифметическое введённых чисел равно {avg}");
}

Console.Write("Введите числа через пробел, по окончании ввода нажмите Enter: ");
List<int> numbers = Console.ReadLine().Split().Select(Int32.Parse).ToList();
Average(numbers);
