// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76


Console.Write("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());

double[] GenerateArray(int count) {
    double[] array = new double[count];
    for (int i=0; i<count; i++) {
        array[i] = (new Random().NextDouble())*(new Random().Next(-10,11));
        Console.WriteLine(array[i]);
    }
    return array;
}
double[] array = GenerateArray(count);

double min=array[0];
double max=array[0];    
for (int i=0; i<array.Length; i++) {
        if (array[i]>max) {
            max=array[i];
        } else 
            if (array[i]<min) {
                min=array[i];
            }
}
Console.WriteLine("Максимальный элемент массива (округл.): {0:N3}", max);
Console.WriteLine("Минимальный элемент массива (округл.): {0:N3}", min);
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна " + (max-min));
