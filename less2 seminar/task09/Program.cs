// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int Multiplicity(int num1, int num2)
{
    int res = num1 % num2;
    return res;
}
Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(numberA, numberB);

if (result ==0) 
{
    Console.WriteLine("кратно");
}
else Console.WriteLine($"не кратно, остаток {result}");

Console.WriteLine(result);
