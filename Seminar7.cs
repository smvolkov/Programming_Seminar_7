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

    //Console.WriteLine(String.Join(" ", matrix));
}

Matrix();