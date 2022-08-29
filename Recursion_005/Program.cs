// Напишите программу на C # Sharp для подсчета количества цифр в числе с помощью рекурсии.

class Recursion
{
    static void Main(string[] args)
    {
    Console.Write("\n\n Рекурсия : Показать количество цифр, из которых состоит число:\n");
    Console.Write("-------------------------------------------------------------------\n");
	Console.Write(" Введите число : ");
	int num = Convert.ToInt32(Console.ReadLine());  
    Console.Write("\n Количество цифр в числе {0} составляет : {1} ", num, getDigits(num, 0));
    Console.ReadLine();
    }
    public static int getDigits(int n, int count)
    {
        if (n == 0)
        {
           return count;
        }
        else 
        {
            return getDigits(n / 10, ++count);
        }
    }
}

