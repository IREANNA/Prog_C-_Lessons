// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число: ");
string a = Console.ReadLine();

switch (a) {
    case "1": Console.WriteLine("Это число соответствует понедельнику"); break;
    case "2": Console.WriteLine("Это число соответствует вторнику"); break;
    case "3": Console.WriteLine("Это число соответствует среде"); break;
    case "4": Console.WriteLine("Это число соответствует четвергу"); break;
    case "5": Console.WriteLine("Это число соответствует пятнице"); break;
    case "6": Console.WriteLine("Это число соответствует субботе"); break;
    case "7": Console.WriteLine("Это число соответствует воскресению"); break;
    default: Console.WriteLine("Введено некорректное значение"); break;
}

