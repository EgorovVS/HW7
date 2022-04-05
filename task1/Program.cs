/* Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами. */

double[,] Massive = FillArray(4, 4);
PrintArray(Massive);

double[,] FillArray(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 10;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}
