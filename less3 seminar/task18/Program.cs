﻿// Задача 18: Напишите программу, которая 
//по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

 Console.WriteLine ("Введите номер четверти");
 int number = Convert.ToInt32(Console.ReadLine());

 string Range(int num)
 {
    if(num == 1) return "x > 0 и y > 0";
    if(num == 2) return "x < 0 и y > 0";
    if(num == 3) return "x < 0 и y < 0";
    if(num == 4) return "x > 0 и y < 0";
    return "не верный номер четверти";
}

string result = Range (number);
Console.WriteLine (result);


//  Console.WriteLine("Введите номер четверти");
//  string number = Console.ReadLine();

//  string Range(string num)
//  {
//     if(num == "1") return "x > 0 и y > 0";
//     if(num == "2") return "x < 0 и y > 0";
//     if(num == "3") return "x < 0 и y < 0";
//     if(num == "4") return "x > 0 и y < 0";
//     return "не верный номер четверти";
// }
// string result = Range(number);
// Console.WriteLine (result);