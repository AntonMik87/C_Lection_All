// упорядочить массив  1, 5, 4, 3, 2, 6, 7, 1, 1
Console.Clear();
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
}
Console.WriteLine();

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1; i++)
//     {
//         int minPos = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPos]) minPos = j;
//         }

//         int temporaru = array[i];
//         array[i] = array[minPos];
//         array[minPos] = temporaru;
//     }

// }
// Вывод от большего к меньшему  1, 5, 4, 3, 2, 6, 7, 1, 1
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
             if (array[j] > array[maxPos]) maxPos = j;
        }

        // int temporaru = array[i];
        // array[i] = array[maxPos];
        // array[maxPos] = temporaru;
    }

}


// Вывод в обратном порядке
// void SelectionSort(int[] array)
// {
//     for (int j = array.Length - 1; j >= 0; j--)
//     {
//         Console.Write($"{array[j]} ");
//     }
// }

PrintArray(array);
Console.WriteLine();
SelectionSort(array);
PrintArray(array);