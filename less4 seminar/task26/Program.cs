// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 13 Задача
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int ThirdDigit(int num)
// {
//     while (num > 1000)
//     {
//      num = num / 10;
//     }
//     return num % 10;
// }
// if (number < 0) number = -number;
// if (number > 99)
// {
//     int result = ThirdDigit(number);
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

Console.WriteLine("введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num)
{
    //     for (int i = 0; i < num; i++)
    int digit = 0;
    while (num != 0)
    {
        num = num / 10;
        digit++;
    }
    return digit;
}

int digitNumber = NumberDigit(number);
Console.WriteLine($"{number} -> {NumberDigit(number)}");
