﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число A = ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число B = ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите третье число C = ");
int C = int.Parse(Console.ReadLine());
int max = A;
if (B>max)
{
    max = B;
}
if (C>max)
{
    max = C;
}
Console.WriteLine($"Максимальное число = {max}");