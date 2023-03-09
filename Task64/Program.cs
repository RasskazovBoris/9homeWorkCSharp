// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


int numberN = SetNumber("N");

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numbers(int n)
{
    if (n == 1) return 1;
    System.Console.Write(n + ", ");
    return numbers(n - 1);
}
System.Console.WriteLine(numbers(numberN));