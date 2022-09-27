// Напишите программу на C #, чтобы проверить, равны ли первый элемент и последний элемент массиву целых чисел, а длина равна 1 или более

int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
Console.WriteLine((array[0] == array[array.Length - 1]) && (array.Length >= 1));

// int[] nums = {};
// Console.WriteLine((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])));