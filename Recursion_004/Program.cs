// Напишите программу на C # Sharp для отображения отдельных цифр данного числа с помощью рекурсии.

public class Recursion
{
    static void Main()
    {
    Console.Write("\n\n Рекурсия : Показать отдельные цифры, из которых состоит число:\n");
    Console.Write("-------------------------------------------------------------------\n");
	Console.Write(" Введите число : ");
	int num = Convert.ToInt32(Console.ReadLine());    
    Console.Write(" Число {0} состоит из цифр : ", num);
    separateDigits(num);
    Console.Write("\n\n");
    }
    static void separateDigits(int n)
    {
        if (n < 10)
        {
        Console.Write(" {0} ", n);
        return;
        }
        separateDigits(n / 10); 
        Console.Write(" {0} ", n % 10);
    }
}
