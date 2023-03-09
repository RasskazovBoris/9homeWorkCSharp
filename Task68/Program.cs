// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int numberM = SetNumber("M");

int numberN = SetNumber("N");

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
if (numberM > 3 || numberN > 11) System.Console.WriteLine("На Вашем месте я бы этого не делал...");
else if (numberM < 0 || numberN < 0) System.Console.WriteLine("Введите неотрицательное число!");
else
{
    int Ackermann(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if (n != 0 && m == 0)
            return Ackermann(n - 1, 1);
        else
            return Ackermann(n - 1, Ackermann(n, m - 1));
    }
    System.Console.WriteLine($"A({numberM},{numberN}) = {Ackermann(numberM, numberN)}");
}