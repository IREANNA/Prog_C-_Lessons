// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Numb(string str) {
    Console.Write(str);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int a =Numb("Введите размер массива: ");
int start=Numb("Введите начальное значение интервала данных: ");
int end = Numb("Введите конечное значение интервала данных: ");


int[] GenerateArray(int count, int start, int end) {
    int[] array = new int[count];
    for (int i=0; i<count; i++) {
        array[i] = new Random().Next(start,end);
    }
    return array;
}
int[] array = GenerateArray(a, start, end);
Console.WriteLine(String.Join(", ", array));


int sum = 0;
for (int i=0; i<array.Length; i+=2) {
        sum+=array[i];
}
Console.WriteLine("Cуммa элементов, стоящих на нечётных позициях равна " + sum);
