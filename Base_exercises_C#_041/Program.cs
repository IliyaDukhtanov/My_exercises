// Напишите программу на C #, чтобы проверить, содержит ли данная строка символ «w» от 1 до 3 раз.

void StringCheck(string symbols)
{
int count = 0;
for (int i = 0; i < symbols.Length; i++)
{
    if (symbols[i] == 'w') count++;
}
if (count <= 3 && count >= 1) Console.WriteLine("Символ 'w' встречается в ведённой строке от 1 до 3 раз");;
}

Console.WriteLine("Введите строку: ");
string symbols = Console.ReadLine();
StringCheck(symbols);
