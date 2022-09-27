// Напишите программу на C #, чтобы получить большее значение между первым и последним элементом массива (длина 3) целых чисел.

// int[] numbers = {1, 2, 5, 7, 8};
// int iMax = 1; 
// for (int i = 1; i < numbers.Length - 1; i++)
// {
//     if (numbers[i] > numbers[1]) iMax = i;
// }
// Console.WriteLine(numbers[iMax]);


// Напишите программу на C # для создания нового массива длины, содержащего средние элементы трех массивов (каждый длиной 3) целых чисел

// int[] array1 = {1, 2, 5};
// int[] array2 = {0, 3, 8};
// int[] array3 = {-1, 0, 2};

// int[] resultArray = {array1[1], array2[1], array3[1]};
// Console.WriteLine("\nНовый массив: [{0}]", string.Join(", ", resultArray));


// Напишите программу на C #, чтобы проверить, содержит ли массив нечетное число.

int[] array = {2, 4, 7, 8, 6};
Console.WriteLine("\nИсходный массив: [{0}]", string.Join(", ", array));
Console.WriteLine("Проверить, есть ли в массиве четные числа? "+even_odd(array));

static bool even_odd(int[] array)
{
    foreach (var n in array)
    {
        if (n % 2 == 0) return true;
    }
    return false;
}