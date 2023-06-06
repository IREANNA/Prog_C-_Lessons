// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

switch (Numb("Введите номер задачи (64, 66 или 68): "))
{
    case 64:
        Console.WriteLine(Task64(Numb("Введите целое число: ")));
        break;
    case 66:
        Console.WriteLine(SumRecurs(Numb("Введите начальное число: "), 
                                    Numb("Введите конечное число: ")));
        break;
    case 68:
        Task68();
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

string Task64(int a)
{
    if (a == 1) return $"{a} ";
    else if (a > 0) return $"{a} " + Task64(a - 1);
    else return $"{a} " + Task64(a + 1);
}

int SumRecurs(int m, int n)
{
    if (n == m) return m;
    else return m + SumRecurs(m + 1, n);
}

double Ackermann(double n, double m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackermann(n - 1, 1);
    else return Ackermann((n - 1), Ackermann(n, m - 1));
}

void Task68()
{
    int numberFirst = Numb("Введите первое число: ");
    int numberSecond = Numb("Введите второе число: ");
    if (numberFirst>=0 && numberSecond>=0) {
        Console.WriteLine(Ackermann(numberFirst, numberSecond));
    } else {
        Console.WriteLine("Введено некорректное значение");
    }
}