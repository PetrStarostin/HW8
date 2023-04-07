//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
// int[,] Create2dArray(int row , int column)
// {
// int[,] array = new int[row,column];
// for(int i = 0; i < row; i++)
// for(int j = 0; j < column; j++)
// array[i,j] = new Random().Next(1,10);

// return array;
// }

// void WriteArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i,j]} ");

// Console.WriteLine();
// }
// Console.WriteLine();
// }

// int[,] SortArray(int[,] array)
// {
// bool swap = true;
// for(int i = 0; i < array.GetLength(0); i++)
// {
// swap = true;
// while(swap)
// {
// swap = false;
// for(int j = 1; j < array.GetLength(1); j++)
// {
// int temp = 0;
// if(array[i,j - 1] < array[i,j])
// {
// temp = array[i,j - 1];
// array[i,j - 1] = array[i,j];
// array[i,j] = temp;
// swap = true;
// }

// }
// }
// }
// return array;
// }

// int[,] array = Create2dArray(6,6);
// WriteArray(array);
// array = SortArray(array);
// WriteArray(array);

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
// int[,] Create2dRectangleArray(int row , int column)
// {
//     int[,] array = new int[row,column];
//     if(row != column)
//     {
//         for(int i = 0; i < row; i++)
//             for(int j = 0; j < column; j++)
//                 array[i,j] = new Random().Next(1,10);

//         return array;
//     }

//     return array;
// }

// void WriteArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j]} ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void MinRowIndex(int[,] array)
// {
//     int rowindex = 0 ;
//     int temp = 0 ;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int tempsum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             tempsum += array[i,j];
//         }
//         if(i == 0)
//             temp = tempsum;
//         if(temp > tempsum)
//         {
//             temp = tempsum;
//             rowindex = i ;
//         }
//     }

//     Console.Write($"Строка под номером {rowindex + 1} имеет наименьшую сумму");
// }

// int[,] array = Create2dRectangleArray(5,7);
// WriteArray(array);
// MinRowIndex(array);

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

// int[,] Create2dArray(int row , int column)
// {
//     int[,] array = new int[row,column];  
//     for(int i = 0; i < row; i++)
//         for(int j = 0; j < column; j++)
//              array[i,j] = new Random().Next(1,10);

//     return array;
// }

// void WriteArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j]} ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MatrixMulti(int[,] array1 , int[,] array2)
// {
//     int[,] multiarray = new int[array1.GetLength(1),array2.GetLength(0)];
//     for(int array1row = 0; array1row < array1.GetLength(0); array1row++)
//     {
//         for(int array2column = 0;array2column < array1.GetLength(0); array2column++)
//         {
//             for(int i = 0 ; i < array2.GetLength(0); i++)
//             {
//                 multiarray[array1row,array2column] += array1[array1row,i] * array2[i,array2column];
//             }
//         }
//     }
//     return multiarray;
// }

// int[,] array1 = Create2dArray(2,2);
// WriteArray(array1);
// int[,] array2 = Create2dArray(2,2);
// WriteArray(array2);
// int[,] multiarray =  MatrixMulti(array1,array2);
// WriteArray(multiarray);

//формируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

// int[,,] Create3dArray(int layer,int row , int column)
// {
//     int[,,] array = new int[layer,row,column];  
//     for(int i = 0; i < layer; i++)
//         for(int j = 0; j < row; j++)
//             for(int m = 0; m < column; m++)
//                 array[i,j,m] = GetUniqueValue(array, i, j, m);
//     return array;
// }

// int GetUniqueValue(int[,,] matrix, int i, int j, int k)
// {
//     int value = 0;
//     bool exist = true;
//     while (exist)
//     {
//         bool _break = false;
//         value = new Random().Next(10, 100);
//         for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
//         {
//             if (_break) { break; }
//             for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
//             {
//                 if (_break) { break; }
//                 for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
//                 {
//                     if (matrix[i1, j1, k1] == value) { _break = true; break; }
//                     if (i1 == i && j1 == j && k1 == k) { exist = false; }
//                 }
//             }
//         }
//     }
//     return value;
// }

// void WriteArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int m = 0; m < array.GetLength(2); m++)
//                 Console.Write($"{array[i,j,m]} - {(i,j,m)} ");

//         Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] array = Create3dArray(3,3,3);
// WriteArray(array);