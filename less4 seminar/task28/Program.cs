// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact; //Math.Abs(fact);
}

if (number > 1)
{
    int factorial = Factorial(number);

    Console.WriteLine($"произведение чисел от 1 до {number} = {factorial}");
}

else Console.WriteLine("требуется ввести натуральное число");