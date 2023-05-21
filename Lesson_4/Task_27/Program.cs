// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumN (int a) {
    int sN = a%10;
    while (a/10 > 0) {
        a /= 10;
        sN+=a%10;
    } 
    return sN;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр числа {n} равна {SumN(n)}");