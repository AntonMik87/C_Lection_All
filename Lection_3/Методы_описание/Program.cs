// Примеры раздичных методов.
// Вид 1 - Ничего не возвращают и ничего не прнемают
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// //  Как вызывают такой метод. Указываем идификатор - Method1()
//!!  - Method1();

// Вид 2 - Методы ничего не возвращают, но могут принемать какието аргументы. аргумент - (sring msg). Идификатор это - Method2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Как вызвать
// - Method2("Текст сообщения");

// Именованные аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Новый текст");

// Вди 3 Методы которы что то возвращают но ничего не принемает. Обязательно указываем тип данных - (int); Аргументы не принемает.
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// // Вызов
// int year = Method3();
// Console.WriteLine(year);

// Вид4 Методы принимают и возвращают
string Method4(int count, string text)  // хотим вывести text друг за другом count раз!
{
    int i = 0;
    string result = String.Empty;    //Переменная result - в нее кладем окончательный результат String.Empty - означает пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}
string res = Method4(10, "z");
Console.WriteLine(res);