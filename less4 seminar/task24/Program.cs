﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i < num; i++)
    {
        sum += i;

    }
    return sum;
}
if (number > 1)
{
int sumNumbers = SumNumbers(number);

Console.WriteLine($"сумма чисел от 1 до {number} = {sumNumbers}");
}
else Console.WriteLine("требуется ввести натуральное число");