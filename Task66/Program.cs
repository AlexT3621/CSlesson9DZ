/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int sumTo(int a, int b)
{
    if (a <= b) return sumTo(a, b - 1) + b;
    else return 0;

}

Console.WriteLine(sumTo(1, 15));


