// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a+1, b) + $"{a} ";
    else return String.Empty;
}

System.Console.WriteLine("Entet the number you want to start from: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Entet the number where you want to finish: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(NumbersRec (a, b));
