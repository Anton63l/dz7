//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Matrix(int rows, int cols)
// {
//     double[,] matrix = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {

//             matrix[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
//             Console.Write($"{matrix[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }

//     return matrix;
// }


// System.Console.Write("Введите число строк для двумерного массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число столбцов для двумерного массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Matrix(m, n);
