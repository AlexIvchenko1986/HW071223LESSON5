// ## Задача 2: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

// **Пример :**
// *   4 3 1 => 4 6 2
// *    2 6 9    2 6 9
// *    4 6 2    4 3 1

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MoveRows(int[,] array, int temp)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i,j];
            array[i,j] = array[array.Length - 1 - i,j];
            array[array.Length - 1  - i,j] = temp;
        }
        Console.Write($"{array} ");
    }
}

int[,] array = new int[3, 3];

FillArray(array);
Console.WriteLine();
PrintArray(array);
MoveRows(array);