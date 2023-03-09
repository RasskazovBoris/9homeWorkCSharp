// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

int numberM = SetNumber("M");

int numberN = SetNumber("N");

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}
if (numberM == numberN) System.Console.WriteLine($"Между {numberM} и {numberN} нет натуральных чисел!");

else
{
    int numbers(int m)
    {
        if (m + 1 == numberN) return m + numberN;

        return m + numbers(m + 1);
    }
    System.Console.WriteLine($"Сумма натуральных чисел между {numberM} и {numberN} = {numbers(numberM)}");
}