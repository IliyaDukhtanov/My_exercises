// Напишите программу на C # для перевода из градусов Цельсия в Кельвины и Фаренгейты


void CelsiusConvert(double celsius)
{
    Console.WriteLine($"Температура в Кельвинах равна {celsius + 273.15}");
    Console.WriteLine($"Температура по Фаренгейту равна {celsius *  1.8 + 32}");
}

Console.Write("Введите температуру в градусай Цельсия: ");
double celsius = Convert.ToDouble(Console.ReadLine());
CelsiusConvert(celsius);