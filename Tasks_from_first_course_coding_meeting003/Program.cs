// Задача 1. Написать программу
// Нахождение индексов максимального и минимального элемента массива

static int[] CreateArray(int number) // создание массива
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
static void PrintArray(int[] array)  // печать массива
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Clear();
Console.WriteLine("Введите число элементов массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
int i = 0;
int iMin = 0;
int iMax = 0;
while (i < length)
{
    if (array[i] > array[iMax])
    {
        iMax = i;
    }
    else {}
    if (array[i] < array[iMin])
    {
        iMin = i;
    }
    else {}
i++;
}
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Максимальный элемент массива:" + array[iMax]);
Console.WriteLine("Минимальный элемент массива:" + array[iMin]);