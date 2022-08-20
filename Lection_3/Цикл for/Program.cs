// Цикл for и цикл в цикле
string Method4(int count, string text)  // хотим вывести text друг за другом count раз!
{
    // int i = 0;
    string result = String.Empty;    //Переменная result - в нее кладем окончательный результат String.Empty - означает пустая строка
    for (int i = 0; i < count; i++)
    // while (i < count)
    {
        result = result + text;

    }
    return result;

}
string res = Method4(10, "z");
Console.WriteLine(res);

// Цикл в цикле таблица умножения.
//for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j} = {i * j}");
    }
    Console.WriteLine();
}