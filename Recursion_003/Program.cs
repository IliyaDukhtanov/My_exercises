// Напишите программу на C # Sharp, чтобы найти сумму первых n натуральных чисел, используя рекурсию.

class Recursion
{
    static void Main(string[] args)
    {
    Console.Write("\n\n Рекурсия : сумма первых n натуральных чисел :\n");
    Console.Write("--------------------------------------------------\n");
	Console.Write(" Сколько чисел суммировать : ");
	int n = Convert.ToInt32(Console.ReadLine());    
    Console.Write(" Сумма первых {0} натуральных чисел : {1}\n\n", n,SumOfNumbers(1,n));
    }
    static int SumOfNumbers(int min, int max)
    {
        return CalcSum(min, max);
    }
    static int CalcSum(int min, int n)
    {
        if (n == min) return n;
        else          return n + CalcSum(min, n - 1); 
    }
}