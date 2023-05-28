// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите номер задачи: ");
int task=Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 41:
        Console.WriteLine("Введите вариант решения 1,2 или 3: ");
        switch (Convert.ToInt32(Console.ReadLine())) {
            case 1:
                task41_1();
                break;
            case 2:
                task41_2();
                break;
            case 3:
                task41_3();
                break;
            default:
                Console.WriteLine("Вариант с таким номером отсутствует: ");
                break;
        }
        break;
    case 43:
        task43();
        break;
    default:
        Console.WriteLine("Задача с таким номером отсутствует: ");
        break;
}

int Numb(string str) {
    Console.Write(str);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void task41_1(){
    Console.WriteLine("Введите целые числа через пробел (последний символ также пробел): ");
    string numbers= Console.ReadLine();
    int count = 0;
    int num=0;
    int indication=1;
    for (int i = 0; i < numbers.Length; i++) {
        string char_=Convert.ToString(numbers[i]);
        switch (char_) {
            case " ": 
                if (num*indication >0) count+=1;
                indication=1;
                break;
            case "-":
                indication=-1;
                break;
            default:
                num+=num*10+Convert.ToInt32(char_);
                break;
        }
    }
    Console.WriteLine("Количество положительных чисел: " + count);
}

void task41_2(){
    Console.WriteLine("Введите целые числа (допустимые разделители - пробел, запятая, точка с запятой): ");
    char[] separators = new char[] { ' ', ',', ';'};
    string[] numbers= Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
    int[] num = Array.ConvertAll(numbers, int.Parse);
    int count=0;
    for (int i = 0; i < numbers.Length; i++) {
        if (num[i] >0) count+=1;
    }
    Console.WriteLine("Количество положительных чисел: " + count);
}

void task41_3(){
    Console.WriteLine("Введите целые числа через пробел: ");
    string[] numbers= Console.ReadLine().Split();
    int count=0;
    for (int i = 0; i < numbers.Length; i++) {
        if (int.TryParse(numbers[i], out int result)==true){
            if (result>0) count++;
        }
    }
    Console.WriteLine("Количество положительных чисел: " + count);
}

void task43() {
    double k1 =(double)Numb("Введите коэфициент k1 первого уравнения: ");
    double b1 =(double)Numb("Введите коэфициент b1 первого уравнения: ");
    double k2 =(double)Numb("Введите коэфициент k2 второго уравнения: ");
    double b2 =(double)Numb("Введите коэфициент b2 второго уравнения: ");

    double x = (b1-b2)/(k2-k1);
    double y = (k1*b2-k2*b1)/(k1-k2);

    Console.WriteLine($"Координаты точки пересечения ({x}, {y})");
}
