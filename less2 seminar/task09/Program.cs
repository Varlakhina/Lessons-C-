﻿//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10 - 99 --> {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;
//if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {firstDigit}");
//else Console.WriteLine($"наибольшая цифра числа {secondDigit}");

int MaxDigit(int num)
{
   int firstDigit = numb / 10;
   int secondDigit = num % 10;
   if (firstDigit > secondDigit) return firstDigit;
   return secondDigit;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра числа {MaxDigit}");

int maxDigit1 = MaxDigit(12);