﻿// Напишите программу C # Sharp, чтобы распечатать результат указанных операций. Перейти к редактору
// Тестовые данные:
// -1 + 4 * 6
// (35+ 5)% 7
// 14 + -4 * 6/11
// 2 + 15/6 * 1 - 7% 2

static void Oparations()
{
    Console.WriteLine($"-1 + 4 * 6 = {-1+4*6}");
    Console.WriteLine($"(35 + 5) % 7 = {(35+5)%7}");
    Console.WriteLine($"14 + -4 * 6 / 11 = {14+(-4)*6/11}");
    Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2+15/6*1-7%2}");
}
Oparations();