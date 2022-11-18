// Задача 18: Напишите программу, которая 
//по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

//  Console.WriteLine ("Введите номер четверти");
//  int number = Convert.ToInt32(Console.ReadLine());

//  string Range(int num)
//  {
//     if(num == 1) return "x > 0 и y > 0";
//     if(num == 2) return "x < 0 и y > 0";
//     if(num == 3) return "x < 0 и y < 0";
//     if(num == 4) return "x > 0 и y < 0";
//     return "неверный номер четверти";
// }

// string result = Range (number);
// Console.WriteLine (result);


 Console.WriteLine("Введите номер четверти");
 string number = Console.ReadLine();

 string Range(string num)
 {
    if(num == "1") return "x > 0 и y > 0";
    if(num == "2") return "x < 0 и y > 0";
    if(num == "3") return "x < 0 и y < 0";
    if(num == "4") return "x > 0 и y < 0";
    return "неверный номер четверти";
}
string result = Range(number);
Console.WriteLine (result);

//warning CS8600: Преобразование литерала, допускающего значение NULL 
//или возможного значения NULL в тип, не допускающий значение NULL.
  
//warning CS8604: Возможно, аргумент-ссылка, допускающий значение NULL, 
//для параметра "num" в "string Range(string num)". 

// Console.WriteLine("введите номер четверти");
// string number = Console.ReadLine();

// string coord(string num)
// {
//     if (num == "1") return "x > 0, y > 0";
//     if (num == "2") return "x < 0, y > 0";
//     if (num == "3") return "x < 0, y < 0";
//     if (num == "4") return "x > 0, y < 0";
//     return "введены некорректные данные";
// }

// string coordinates = coord(number);

// Console.WriteLine(coordinates);

