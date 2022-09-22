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


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Заполнение рандомного массива и вывод на печать
// void FillAndPrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write(array[i, j] + " ");

//         }
//         Console.WriteLine();

//     }
// }

// void ReturnElement(int[,]array, int rows, int cols){
//     Console.WriteLine();

//     if (rows < array.GetLength(0) && cols < array.GetLength(1)) Console.WriteLine(array[rows, cols]);
//     else Console.WriteLine($"{rows}{cols} -> такого числа в массиве нет");

// }


// Console.Write("Введите номер строки элемента с нумерацией от 0: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер строки элемента с нумерацией от 0: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// FillAndPrintArray(matrix);
// ReturnElement(matrix,x,y);



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 

// Задаем массив рандомных чисел и выводим его на печать
// int[,] Matrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {

//             matrix[i, j] = new Random().Next(0, 10);
//             Console.Write($"{matrix[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
//    Console.WriteLine();
//     return matrix;
// }


// // Подсчитываем среднее арифметическое
// void AverageSum(int[,] arr)
// {
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"Среднее арифметическое столбца {j + 1} --> { sum / arr.GetLength(0)}\t");
// }
// }

// AverageSum(Matrix(3,4));
