// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Numb(string str) {
    Console.Write(str);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int a = Numb("Введите размер массива: ");

int[] GenerateArray(int count) {
    int[] array = new int[count];
    for (int i=0; i<count; i++) {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int[] array = GenerateArray(a);
Console.WriteLine(String.Join(", ", array));

int count = 0;
for (int i=0; i<array.Length; i++) {
    if (array[i]%2==0) {
        count+=1;
    }
}
Console.WriteLine("Количество элементов с четным значением " + count);