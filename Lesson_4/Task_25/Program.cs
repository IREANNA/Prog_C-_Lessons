// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double myPow (double a, int n) {
    double aN = a;
    for (int i=1; i<n; i++) {
        aN *= a; 
    }
    return aN;
}

Console.Write("Введите число, возводимое в степень: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение степени: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>0) {
    Console.Write( $"{a} в степени {n} равно {myPow(a,n)}");
} else 
    if (n==0) {
        Console.Write( $"{a} в степени {n} равно 1");
    } else {
        Console.Write( $"{a} в степени {n} равно {1/myPow(a,n*(-1))}");
    }   
