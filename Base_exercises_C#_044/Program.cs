// Напишите программу на C # для создания новой строки каждого другого символа (нечетная позиция) из первой позиции данной строки.
using System;

//Вариант 1
// static void OutputOdd(string input)
// {
//     for (int i = 0; i < input.Length; i++)
//     {
//         Console.Write(input[i]);
//         i++;
//     }
// }

//Вариант 2
Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
var output = string.Empty;
for (int i = 0; i < input.Length; i++)
{
    if (i % 2 == 0) output += input[i];
}
Console.WriteLine(output);


