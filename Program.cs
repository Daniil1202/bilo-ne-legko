



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





void Sorting( int[,] matrix)
{

    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            for (int k = j+1; k < matrix.GetLength(1); k++)
            {

                if (matrix [i,k] > matrix[i,j])
                {
                    int temp = matrix[i,k];
                    matrix[i,k] = matrix[i,j];
                    matrix [i,j] = temp;
                }

            }
        }
    }
    Console.WriteLine();
    Printmatrix(matrix);

}


void Fillmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}\t");
        }
        Console.WriteLine();
    }
}




Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, cols];


Fillmatrix(matrix);
Printmatrix(matrix);
Sorting(matrix);





// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// void Fillmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void Printmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Sum1(int[,] matrix, int[] array)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[i] += matrix[i, j];
//         }
//     }


// }
// void FindMinSum(int[] array)
// {
//     int min = array[0];
//     int index=0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             index=i;
//         }
//     }
//     Console.Write($"Наименьшая сумма элементов в {index + 1} строке ");

// }


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// int[] array = new int[matrix.GetLength(0)];

// Fillmatrix(matrix);
// Printmatrix(matrix);
// Sum1(matrix, array);
// FindMinSum(array);





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// void Fillmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void Printmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SumMatrix(int[,] matrix, int[,] matrix2, int[,] matrix3)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1); k++)
//             {
//                 matrix3[i, j] += matrix[i,k]* matrix2[k,j];
//             }
//         }
//     }
//     Printmatrix(matrix3);
// }



// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];
// int[,] matrix2 = new int[rows, cols];
// int[,] matrix3 = new int[rows, cols];


// Fillmatrix(matrix);
// Fillmatrix(matrix2);
// Printmatrix(matrix); 
// Printmatrix(matrix2);
// SumMatrix(matrix,matrix2,matrix3);







// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void FillArray(int[,,] array)
// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = count;
//                 count += 3;
//             }
//         }
//     }
// }

// Console.WriteLine("Введите количество столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите высоту");
// int height = Convert.ToInt32(Console.ReadLine());


// int[,,] array = new int[rows, cols, height];

// FillArray(array);
// PrintArray(array);