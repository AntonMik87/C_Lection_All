// // Array + функции
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //              0    1   2   3   4   5   6   7  8 
// int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };


// int result = Max(Max(array[0], array[1], array[2]),
// Max(array[3], array[4], array[5]),
// Max(array[6], array[7], array[8])
// );


// Console.WriteLine(result);

// //           0    1   2   3   4   5   6   7  8 
// int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 41 };
// int n = array.Length;
// int find = 41;                          // Находит индекс элемента массива
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break; // прерывает работу как только нащел элемен (если в массиве несколько одинаковых элементов)
//     }
//     index++;
// }
// FillAraay - заполнить массив.
void FillAraay(int[] numbers)  // Метод void не возвращает значения!!! (не нужен return)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);

        index++;
    }
}
// PrintArray - распечатывает массив
void PrintArray(int[] num)
{
    int count = num.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(num[pos] + ",");
        pos++;
    }
}
// найти позицию элемента с помощью метода!! метод будет возвращать позицию. Метод indexOf определяет точное местоположение символа Юникода, получая его нулевой индекс. Это также помогает извлекать подстроки из программы. Вам нужно только добавить условный оператор и разрешить консоли. Написать команду для обработки выходных данных.
int IdexOf(int[] numbers, int find)
{
    int count = numbers.Length;
    int ind = 0;
    int position = -1; // сохраняем наш найденный элемент
    while (ind < count)
    {
        if (numbers[ind] == find)
        {
            position = ind;
            break;
        }
        ind++;
    }
    return position;
}


int[] array = new int[10]; // конструкция - содай новый массив в котором будет 10 элементов. По умолчанию элемнты = 0

FillAraay(array);   // Метод заполняет массив
PrintArray(array);  // Метод распечатывает массив
Console.WriteLine();

int p = IdexOf(array, 4);
Console.WriteLine(p);