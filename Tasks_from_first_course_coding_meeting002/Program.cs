// Задача 6. Написать программу нахождения факториала N

Console.Write("Введите число N, для которого нужно вычислить факториал: ");
int n = Convert.ToInt32(Console.ReadLine());
int fact = 1;
for (int i = 1; i <= n; i++)
{
    fact = fact * i;
}
Console.WriteLine(n +"! = " + fact);
