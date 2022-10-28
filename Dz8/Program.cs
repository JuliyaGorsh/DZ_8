/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

// int[,] FillPrintArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,] CreateNewMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int MaxPosition = j;
//             for (int index = j + 1; index < array.GetLength(1); index++)
//             {
//                 if (array[i, index] > array[i, MaxPosition]) MaxPosition = index;
//             }
//             int chislo = array[i, j];
//             array[i, j] = array[i, MaxPosition];
//             array[i, MaxPosition] = chislo;
//         }
//     }
//     return array;
// }
// void PrintNewMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = new Random().Next(3, 6);
// int n = new Random().Next(3, 6);
// int[,] Array = FillPrintArray(m, n);
// int[,] NewArray = CreateNewMatrix(Array);
// Console.WriteLine();
// PrintNewMatrix(NewArray);

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 6);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int x = new Random().Next(2, 5);
// int y = new Random().Next(2, 5);
// int[,] array = new int[x, y];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Сумма строк:");

// int index = 0;
// int minsum = 0;
// for (int i = 0; i < x; i++)
// {
//     int sum = 0;

//     for (int j = 0; j < y; j++)
//     {
//         sum += array[i, j];

//     }
//     Console.WriteLine($"{sum} ");
//     if (i == 0)
//     {
//         minsum = sum;
//     }
//     else if (sum < minsum)
//     {
//         minsum = sum;
//         index = i;
//     }
// }
// string line = string.Empty;
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     line += array[index, j];
// }
// Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");



/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 4);
//         }
//     }
// }
// int[,] PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }
// int[,] DivMatrix(int[,] array1, int[,] array2)
// {
//     var matrix = new int[array1.GetLength(0), array2.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = 0;
//             for (int n = 0; n < array1.GetLength(1); n++)
//             {
//                 matrix[i, j] += array1[i, n] * array2[n, j];
//             }
//         }
//     }
//     return matrix;
// }

// int a = new Random().Next(2, 4);
// int b = new Random().Next(2, 4);
// // int a = 2;
// // int b = 2;
// int[,] array = new int[a, b];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// int c = new Random().Next(2, 4);
// int d = new Random().Next(2, 4);
// // int c = 2;
// // int d = 2;
// int[,] matrix = new int[c, d];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// if (b != c) Console.WriteLine("Матрицы нельзя перемножить");
// else 
// {
//     Console.WriteLine("Результирующая матрица:");
//     PrintArray(DivMatrix(array, matrix));
// }