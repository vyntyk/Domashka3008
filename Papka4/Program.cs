/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
void FillArray(int[,] array, int[,] array2)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < array2.GetLength(0); m++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            array2[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array, int[,] array2)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < array2.GetLength(0); m++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            Console.Write($"{array2[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] array, int[,] array2, int[,] compMatr)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            compMatr[m, n] = array[m, n] * array2[m, n];
        }
    }
}

void PrintCompArray(int[,] compMatr)
{
    for (int m = 0; m < compMatr.GetLength(0); m++)
    {
        for (int n = 0; n < compMatr.GetLength(1); n++)
        {
            Console.Write($"{compMatr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
int[,] matrix1 = new int[2, 2];
int[,] compMatrix = new int[2, 2];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Composition(matrix, matrix1, compMatrix);
PrintCompArray(compMatrix);