// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (a <= 0) {
    Console.Write( "Введено некорректное значение");
} else 
    while (i<= a) {
    Console.Write(Math.Pow(i,3) + ", ");
    i++;
}