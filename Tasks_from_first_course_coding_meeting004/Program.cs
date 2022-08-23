// Задача 2. Нарисовать блок-схему
// Задание на «разворот» массива. Нужно перевернуть массив и
// записать его в обратном порядке.

// Ввод массива (не рандом)

Console.WriteLine("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int i = 0; 
while (i < length)
{
Console.WriteLine("Введите {0}-й элемент", i + 1);
int num = Convert.ToInt32(Console.ReadLine());
array[i] = num;
i++;
}  
Console.WriteLine("Вывод массива"); // печать введённого массива
for (i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
for (i = 0; i < length/2; i++) // счётчик до середины массива и перестановка элементов массива 
{
    int temp = array[i];
    array[i] = array[length - 1 - i];
    array[length - 1 - i] = temp;
}
Console.WriteLine("Вывод массива"); // печать перевёрнутого массива
for (i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}



