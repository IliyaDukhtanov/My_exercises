// Задача 3. Написать программу нахождения среднего арифметического из 4-х чисел.

Console.Write("Введите число A: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
double c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число D: ");
double d = Convert.ToInt32(Console.ReadLine());
double avg = (a+b+c+d)/4;
Console.WriteLine("Среднее арифметические введённых чисел = " + avg);

// *Сделать программу для ввода N чисел и вычисления среднего арифметического