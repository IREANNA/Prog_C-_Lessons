// // Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

switch (Numb("Введите номер задачи (54, 56, 58 или 62): "))
{
    case 54:
        Task54();
        break;
    case 56:
        Task56();
        break;
    case 58:
        Task58();
        break;
    case 62:
        Task62();
        break;
    default:
        Console.WriteLine("Задача с таким номером отсутствует.");
        break;
}

int Numb(string str)
{
    Console.Write(str);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] GenerateArray2dInt(int m, int n, int min, int max)
{
    int[,] array2d = new int[m, n];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(min, max);
        }
    }
    return array2d;
}

void PrintArray2dInt(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write($"{array2d[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void Task54()
{
    int[,] array2d = GenerateArray2dInt(Numb("Введите количество строк массива: "),
                                        Numb("Введите количество столбцов массива: "),
                                        Numb("Введите минимальное значение элементов массива: "),
                                        Numb("Введите максимальное значение элементов массива: "));
    Console.WriteLine("Исходный массив: ");
    PrintArray2dInt(array2d);
    int[] row = new int[array2d.GetLength(1)];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            row[j] = array2d[i, j];
        }
        Array.Sort(row);
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = row[j];
        }
    }
    Console.WriteLine("Построчно отсортированный массив: ");
    PrintArray2dInt(array2d);
}

void Task56()
{
    int[,] array2d = GenerateArray2dInt(Numb("Введите количество строк массива: "),
                                        Numb("Введите количество столбцов массива: "),
                                        Numb("Введите минимальное значение элементов массива: "),
                                        Numb("Введите максимальное значение элементов массива: "));
    Console.WriteLine("Исходный массив: ");
    PrintArray2dInt(array2d);
    int[] sumRow = new int[array2d.GetLength(0)];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            sum += array2d[i, j];
        }
        sumRow[i] = sum;
    }
    
    int minSumRow = sumRow[0];
    int row = 0;
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (minSumRow > sumRow[i])
        {
            minSumRow = sumRow[i];
            row = i;
        }
    }
    Console.WriteLine($"Строка {row + 1} имеет наименьшую сумму");
}

void Task58()
{
    int matrix1Row = Numb("Введите количество строк первой матрицы: ");
    int matrix1Column = Numb("Введите количество столбцов первой матрицы: ");
    int matrix2Row = Numb("Введите количество строк второй матрицы: ");
    int matrix2Column = Numb("Введите количество столбцов второй матрицы: ");
    if (matrix1Column == matrix2Row)
    {
        int minValue = Numb("Введите минимальное значение элементов матриц: ");
        int maxValue = Numb("Введите максимальное значение элементов матриц: ");

        int[,] matrix1 = GenerateArray2dInt(matrix1Row, matrix1Column, minValue, maxValue);
        Console.WriteLine("Первая исходная матрица: ");
        PrintArray2dInt(matrix1);

        int[,] matrix2 = GenerateArray2dInt(matrix2Row, matrix2Column, minValue, maxValue);
        Console.WriteLine("Вторая исходная матрица: ");
        PrintArray2dInt(matrix2);

        int[,] matrixProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrixProduct.GetLength(0); i++)
        {
            for (int j = 0; j < matrixProduct.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                matrixProduct[i, j] = sum;
            }
        }
        Console.WriteLine("Произведение матриц: ");
        PrintArray2dInt(matrixProduct);
    }
    else
    {
        Console.WriteLine("Произведение матриц выполнить не возможно.");
    }
}

void Task62()
{
    int valueArray = Numb("Введите размер квадратного массива: ");
    int[,] array = new int[valueArray, valueArray];

    int i = 0;
    int j = 0;
    int x = 1;
    int k = 0;
    while (x <= valueArray * valueArray)
    {
        array[i, j] = x;
        if (i != j)
        {
            array[j, i] = (array[k, k] + (valueArray - k * 2) * 2) * 2 - 4 - x;
        }
        if (j != valueArray - 1 - k)
        {
            j += 1;
        }
        else if (i != valueArray - 1 - k)
        {
            i += 1;
        }
        else if (x != valueArray * valueArray)
        {
            k += 1;
            i = k;
            j = k;
            x = array[k, k - 1];
        }
        x += 1;
    }
    PrintArray2dInt(array);
}