// Напишите программу на C # для создания новой строки, где первые 4 символа будут в нижнем регистре. 
// Если строка меньше 4 символов, тогда сделайте всю строку в верхнем регистре.

Console.WriteLine("Введите строку символов ");
string symbols = Console.ReadLine();
if (symbols.Length < 4) Console.WriteLine(symbols.ToUpper());
else Console.WriteLine(symbols.Substring(0, 4).ToLower() + symbols.Substring(4, symbols.Length-4));