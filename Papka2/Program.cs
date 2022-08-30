/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.*/
Console.Clear();

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void GetNumRepet(int[,] array)
{
    int[] count = new int[10];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            count[array[i,j]]++;
        }
    }
    for (int i = 0; i < count.Length; i++){
        Console.WriteLine($"Число {i} встретилось {count[i]} раз(а)");
    }
}

int[,] arr = GetArray(6, 6, 0, 10);
PrintArray(arr);
Console.WriteLine();
GetNumRepet(arr);