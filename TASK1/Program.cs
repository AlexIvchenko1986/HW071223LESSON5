// Задача 1: Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, 
//что такого элемента нет.

// **Пример :**
// *   4 3 1 (1,2) => 9
// *   2 6 9




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

int[,] array = new int[3, 4];
//void ShowElementByIndex(int[,] arr, int row, int column)
//{
    Console.WriteLine("Введите номер строки ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца ");
    int column = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row < 0 | row > array.GetLength(0) && column < 0 | column > array.GetLength(1))
            {
                Console.WriteLine("Такого элекмента нету ");
            }
            else
            {
                Console.WriteLine($"Номер элекмента в массиве {array[row, column]}");
            }
        }
    }
//}

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int[,] array = new int[3, 4];

FillArray(array);
Console.WriteLine();
PrintArray(array);
//ShowElementByIndex(array);