// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] point1 = new int[3];
Console.WriteLine("Введите координаты X, Y и Z первой точки: ");
for (int i=0; i < point1.Length; i++) {
    point1[i] = Convert.ToInt32(Console.ReadLine());
}

int[] point2 = new int[3];
Console.WriteLine("Введите координаты X, Y и Z первой точки: ");
for (int i=0; i < point2.Length; i++) {
    point2[i] = Convert.ToInt32(Console.ReadLine());
}

double dist = Math.Round(Math.Sqrt(Math.Pow((point1[0]-point2[0]),2) + Math.Pow((point1[1]-point2[1]),2) + Math.Pow((point1[2]-point2[2]),2)),2); 

Console.WriteLine("Расстояние между точками составляет: " + dist);