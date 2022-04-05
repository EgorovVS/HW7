/* Задача 2: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет. */

int[,] array = FillArray(5, 4);
PrintArray(array);
int rowElement = Prompt("Введите номер строки ");
int columnElement = Prompt("Введите номер столбца ");

SearchElement(array); 

void SearchElement(int[,] array)
{
    if (rowElement > array.GetLength(0) || columnElement > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
   else
{
    Console.WriteLine($"Значение искомого элемента {array[rowElement - 1, columnElement - 1]}");;
}
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 100);
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

int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

