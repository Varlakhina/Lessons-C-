// Задача 22: Напишите программу, 
// которая принимает на вход число (N)
// выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void Sguare(int num) 
{
    int count = 1;
    while (count <= num)
    {
        int multipl = count * count;
        Console.WriteLine($"{count, 4} {multipl, 4}");
        count++;
    }
}

if (number > 0)
Sguare(number);
else Console.WriteLine("число не является натуральным");