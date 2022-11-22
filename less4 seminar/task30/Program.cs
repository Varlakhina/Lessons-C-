// int[] array = new int[8];

// return array;

// array [0] = 345
// array [1] = 345
// array [6] = 345

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
         Console.Write($"{arr[i]},");
        }
}

FillArray(array);
PrintArray(array);