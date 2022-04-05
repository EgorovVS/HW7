/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце. */

int[,] Massive = FillArray(4, 4);
PrintArray(Massive);
Console.WriteLine();

for (int j = 0; j < Massive.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Massive.GetLength(0); i++)
    {
        sum = sum + Massive[i, j];
    }
    double average = Convert.ToDouble(sum/4);
    Console.WriteLine($"Среднее арифметическое {j+1} столбца равно {average}");
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
