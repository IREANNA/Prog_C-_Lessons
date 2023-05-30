// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции(значение) элемента в двумерном массиве, 
// и возвращает значение (позицию) этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

switch (Numb("Введите номер задачи (47, 50 или 52): "))
{
    case 47:
        PrintArray2dDouble(GenerateArray2dDouble(Numb("Введите количество строк массива: "),
                                            Numb("Введите количество столбцов массива: "),
                                            Numb("Введите минимальное значение элементов массива: "),
                                            Numb("Введите максимальное значение элементов массива: ")));
        break;
    case 50:
        int[,] array2d = GenerateArray2dInt(Numb("Введите количество строк массива: "),
                                        Numb("Введите количество столбцов массива: "),
                                        Numb("Введите минимальное значение элементов массива: "),
                                        Numb("Введите максимальное значение элементов массива: "));
        switch (Numb("Введите вариант поиска (1 - значение по позиции, 2 - позиция по значению): "))
        {
            case 1:
                Task50_1(array2d);
                break;
            case 2:
                Task50_2(array2d);
                break;
            default:
                Console.WriteLine("Введено некорректное зачение.");
                break;
        }
        break;
    case 52:
        Task52();
        break;
    default:
        Console.WriteLine("Задача с таким номером отсутствует: ");
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

double[,] GenerateArray2dDouble(int m, int n, int min, int max)
{
    double[,] array2d = new double[m, n];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = (new Random().NextDouble()) * (new Random().Next(min, max));
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
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray2dDouble(double[,] array2d)
{
    int n = Numb("Введите количество десятичных знаков в значении элементов массива (1-17): ");
    if (n < 0 || n > 17)
    {
        Console.Write("Введено некорректное значение. Округление выполняться не будет.");
        n = 17;
    }
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(Math.Round(array2d[i, j], n) + " ");
        }
        Console.WriteLine();
    }
}

void Task50_1(int[,] array2d)
{
    int[] position = { (Numb("Введите позицию элемента: номер строки - ") - 1), (Numb("номер столбца - ") - 1) };
    if (position[0] < array2d.GetLength(0) && position[1] < array2d.GetLength(1))
    {
        Console.WriteLine("Искомое значение: " + array2d[position[0], position[1]]);
    }
    else
    {
        Console.WriteLine("Введено некорректное значение позиции");
    }
    PrintArray2dInt(array2d);
}

void Task50_2(int[,] array2d)
{
    int value = Numb("Введите искомое число: ");
    bool positionIs = false;
    switch (Numb("Введите 1 - для поиска позиции только первого вхождения, 2 - вывода всех позиций: "))
    {
        case 1:
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                if (!positionIs)
                {
                    for (int j = 0; j < array2d.GetLength(1); j++)
                    {
                        if (value == array2d[i, j])
                        {
                            positionIs = true;
                            Console.WriteLine($"Первое вхождение искомого числа на позиции [{i + 1}, {j + 1}]");
                            break;
                        }
                    }
                }
            }
            break;
        case 2:
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (value == array2d[i, j])
                    {
                        positionIs = true;
                        Console.WriteLine($"Искомое число на позиции [{i + 1}, {j + 1}]");
                    }
                }
            }
            break;
        default:
            Console.WriteLine("Вариант с таким номером отсутствует: ");
            break;
    }
    if (!positionIs)
    {
        Console.WriteLine("Искомое число в данном массиве отсутствует");
    }
    PrintArray2dInt(array2d);
}

void Task52() {
    int[,] array2d = GenerateArray2dInt(Numb("Введите количество строк массива: "),
                                        Numb("Введите количество столбцов массива: "),
                                        Numb("Введите минимальное значение элементов массива: "),
                                        Numb("Введите максимальное значение элементов массива: "));
    PrintArray2dInt(array2d);
    for (int i = 0; i < array2d.GetLength(1); i++) {
        int sum = 0;
        for (int j = 0; j < array2d.GetLength(0); j++) {
            sum += array2d[j, i];
        }
        double average = (double)sum / array2d.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов {i + 1} столбца равно {average}");
    }
}

