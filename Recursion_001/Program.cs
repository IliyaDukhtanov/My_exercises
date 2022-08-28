// Напишите программу на C # Sharp для печати первого n натурального числа с использованием рекурсии. 
// Тестовые данные :
// Сколько номеров печатать: 10
// Ожидаемый результат : 1 2 3 4 5 6 7 8 9 10

class Recursion 
{
    static int printNatural(int num, int count)
    {
        if (count < 1) 
        {
            return num;
        }   
        count--;
        Console.Write(" {0} ", num);
        return printNatural(num + 1, count);
    }
    static void Main()
    {
        Console.Write("\n\n Рекурсия : Печать первых n натуральных чисел :\n");
	    Console.Write("---------------------------------------------------\n");
	    Console.Write(" Сколько чисел печатать : ");
	    int num= Convert.ToInt32(Console.ReadLine());
	    // Вызов рекурсивного метода с двумя параметрами.	
	    printNatural(1, num);
	    Console.Write("\n\n");
    } 
}  