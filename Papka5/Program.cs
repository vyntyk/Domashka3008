/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine();
int dimensionX = EnterUserData("Ведите размер массива по X:");
int dimensionY = EnterUserData("Ведите размер массива по Y:");
int dimensionZ = EnterUserData("Ведите размер массива по Z:");
int[,,] randomArray = new int[dimensionX, dimensionY, dimensionZ];
Console.WriteLine();


FillArray(randomArray, dimensionX, dimensionY, dimensionZ);
ShuffleArray(randomArray);
Console.WriteLine();
Console.WriteLine("Введенный трех мерный массив:");
Console.WriteLine();
PrintArray(randomArray);

int[,,] FillArray(int[,,] array, int dimensionX, int dimensionY, int dimensionZ)
{
    int offset = new Random().Next(10, 100);
    int upperBound = 99;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                array[i, j, n] = offset;
                if (offset >= array[0, 0, 0] && offset <= upperBound)
                {
                    offset++;
                }
                else
                {
                    offset--;
                }
                if (offset > upperBound)
                {
                    offset = array[0, 0, 0] - 1;
                }
            }

        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write($"{array[i, j, n]}[{i},{j},{n}] ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] ShuffleArray(int[,,] array)
{
    int temp = 0, i1 = 0, j1 = 0, n1 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        i1 = new Random().Next(0, array.GetLength(0));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            j1 = new Random().Next(0, array.GetLength(1));
            for (int n = 0; n < array.GetLength(2); n++)
            {
                n1 = new Random().Next(0, array.GetLength(2));
                temp = array[i1, j1, n1];
                array[i1, j1, n1] = array[i, j, n];
                array[i, j, n] = temp;
            }
        }
    }
    return array;
}