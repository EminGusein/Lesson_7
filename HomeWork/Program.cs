using MyLib;

// Урок 7. Двумерные массивы

void Task47()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
    // округлёнными до одного знака.

    int m = 5;
    int n = 5;

    double[,] matrix = new double[m, n];

    MyLibClass.FillArray(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }

    }
    MyLibClass.PrintArray(matrix);

}

void Task50()
{
    // Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.

    int rowsIndex = MyLibClass.Input("Введите индекс элемента в строке: ");
    int columnsIndex = MyLibClass.Input("Введите индекс элемента в столбце: ");

    int rows = 10;
    int columns = 10;
    int[,] matrix = new int[rows, columns];

    MyLibClass.FillArray(matrix);
    MyLibClass.PrintArray(matrix);

    if (rowsIndex >= rows && columnsIndex >= columns) Console.WriteLine($"{rowsIndex}, {columnsIndex} -> Такого элемента нет");
    else Console.WriteLine($"{rowsIndex}, {columnsIndex} -> {matrix[rowsIndex, columnsIndex]}");

}

void Task52()
{
    // Задача 52. 
    // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    int rows = 4;
    int columns = 3;

    int[,] matrix = new int[rows, columns];

    MyLibClass.FillArray(matrix);
    MyLibClass.PrintArray(matrix);
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{Math.Round(sum / rows, 2)}; ");
    }

}

Console.Clear();
Task52();





