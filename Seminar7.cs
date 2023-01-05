// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void Matrix()
{
    Console.WriteLine("Введите размер массива m x n");
    Console.WriteLine("Введите m");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n");
    int n = int.Parse(Console.ReadLine());

    double[,] matrix = new double[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble();
            Console.Write($"{Math.Round(matrix[i, j], 1)} ");
        }

        Console.WriteLine();
    }

}

//Matrix();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] IntMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    return matrix;
}

void Position(int[,] matr)
{
    Console.WriteLine("Введите строку: ");
    int str = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите столбец: ");
    int col = int.Parse(Console.ReadLine());

    if (str-1 < 0 || col-1 < 0) Console.WriteLine("Неверные координаты");
    else if (str > matr.GetLength(0) || col > matr.GetLength(1)) Console.WriteLine("Элемента с такими координатами в массиве нет");
    else Console.WriteLine(matr[str-1, col-1]);
}

//Position(IntMatrix(3,4));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Average(int[,] table)
{
    for(int k = 0; k < table.GetLength(1); k++)
    {
        double avgCol = 0;

        for (int l = 0; l < table.GetLength(0); l++)
        {
            avgCol += table[l, k];
        }

        Console.Write($"{Math.Round(avgCol / table.GetLength(0), 1)}; ");
    }
}

Average(IntMatrix(3, 4));