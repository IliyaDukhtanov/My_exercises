// Напишите программу на C # Sharp для печати чисел от n до 1, используя рекурсию.

class Recursion
{
    static int printNumbers(int count, int num)
    {
        if (count < 1)
        {
            return num;
        }
        Console.Write(" {0} ", count);
        count--;
        return printNumbers(count, num);
    }
    static void Main()
    {
        Console.Write("\n\n Рекурсия : Печать натуральных чисел от n до 1 :\n");
	    Console.Write("---------------------------------------------------\n");
	    Console.Write(" Сколько чисел печатать : ");
	    int count= Convert.ToInt32(Console.ReadLine());
	    // Вызов рекурсивного метода с двумя параметрами.	
	    printNumbers(count, 1);
	    Console.Write("\n\n");
    }
}
