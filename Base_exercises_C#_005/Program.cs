// Напишите программу на C # Sharp, чтобы поменять местами два числа. 

Console.Write("Введите первое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"После обмена число A {a}, число B {b}");
ChangeNumbers(a, b);

void ChangeNumbers(int a, int b)
{
    int temp = a;
    a = b; 
    b = temp;
    Console.WriteLine($"После обмена: число A: {a}, число B: {b}");
}