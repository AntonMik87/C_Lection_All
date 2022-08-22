// // Двумерные массивы. Многомерные
Console.Clear();
//     string[,] table = new string[2, 5];  // [,] - указывает на две размерности 2 -СТРОКИ и 5- СТОЛБЦЫ. 
//     // String.Empty Иницилизация срок - пустые строки по умолчанию
//     //table[0,0] - 1й столбик table[0,1]  - 2й стобик table[0,2] - 3й столбик...
//     //table[1,0] - 1я срока   table[1,1]  - 2я срока  table[1,2] - 3я строка...
//     //rows - перевод строки; columns - колонки
//     table[1, 2] = "слово";              // Что бы обратиться к нужному элементу указываем имя массива table
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }





void PrintArray(int[,] matr) // Опишем метод для всего этого PrintArrayпринемает аргумент двумерную табдицу чисел int[,] matr - и пчатает int[,] matrix
{                     
for (int i = 0; i < matr.GetLength(0); i++) // Возвращает. отвечает за строки(int i = 0; i < 3; i++). Вариант записи количества строк matrix.GetLength(0) ноль означает количество строк
{
    for (int j = 0; j < matr.GetLength(1); j++) //Возваращает. отвечает за столбцы matrix.GetLength(1) тоже самое что - (int j = 0; j < 4; j++)
    {
        Console.Write($" {matr[i, j]}");
    }
    Console.WriteLine(); // принудитедбно на новыю строку.
}
}
void FillArray(int[,] matr)//опишем метод который будет заполнять нашу матрицу случайными числами
{
for (int i = 0; i < matr.GetLength(0); i++)
{ 
    for (int j = 0; j <matr.GetLength(1); j++)
    {
        matr[i , j] = new Random().Next(1, 10);
    }
}
}     
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); 