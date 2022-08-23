// Задача 3** (задача повышенной сложности). 
// Найти сумму элементов массива, лежащих между максимальным и минимальным по значению элементами

class Programm 
{
static void Main(string[] args)
{
    Console.Clear();
    int[] array = new int[0]; // сначала создаём пустой массив
    while (true)
    {
        Console.WriteLine("Введите значение массива:"); ///// Создание массива произвольной длины в ручную.
        string value = Console.ReadLine();
        if(value != "end")
        {
            int number = Convert.ToInt32(value);
            int[] newArray = array;
            array = new int[array.Length +1];
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
            array[array.Length-1] = number;
        }
        else
        {
            break; // конец программы ввода массива в ручную
        }
    }  
    static void PrintResult(int[] array)  // вычисление и печать результата
    {
    Console.WriteLine("Вывод массива");
    int posMax = 0;
    int posMin = 0;
    int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " "); // циклы для поиска позиции max и min
            if (array[i] > array[posMax]) posMax = i;
            else {}
            if (array[i] < array[posMin]) posMin = i;
            else {}
        }
        if (posMin > posMax) //// смена индекса позиции max и min, если позиция min > позиции max
        {
            int temp = posMin;
            posMin = posMax; 
            posMax = temp; 
        }
        else {}
        while (posMin < posMax - 1)
        {
            sum += array[posMin + 1];
            posMin++;
        }
        Console.WriteLine();
        //Console.WriteLine("Min = " + array[posMin]);
        //Console.WriteLine("Max = " + array[posMax]);
        Console.WriteLine("Сумма элементов массива между Max и Min  = " + sum);
        Console.WriteLine();
        }
PrintResult(array);
}
}