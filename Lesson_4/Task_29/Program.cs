// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] randArray(){
    int n = new Random().Next(1,9);
    int[] rndArray = new int [n];
    for(int i = 0; i < rndArray.Length;i++){
        rndArray[i] = new Random().Next(0,100);
        }
    return rndArray;
}

Console.WriteLine("[" + String.Join(",", randArray())+ "]");

