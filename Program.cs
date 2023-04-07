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
int[,] Create2dRectangleArray(int row , int column)
{
    int[,] array = new int[row,column];
    if(row != column)
    {
        for(int i = 0; i < row; i++)
            for(int j = 0; j < column; j++)
                array[i,j] = new Random().Next(1,10);

        return array;
    }

    return array;
}

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinRowIndex(int[,] array)
{
    int rowindex = 0 ;
    int temp = 0 ;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int tempsum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            tempsum += array[i,j];
        }
        if(i == 0)
            temp = tempsum;
        if(temp > tempsum)
            rowindex = i ;
    }

    Console.Write($"Строка под номером {rowindex + 1} имеет наименьшую сумму");
}

int[,] array = Create2dRectangleArray(5,7);
WriteArray(array);
MinRowIndex(array);
