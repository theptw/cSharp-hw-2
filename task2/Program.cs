﻿//  Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num>99 ? num.ToString()[2] : "Третьей цифры нет");
        Console.ReadKey(true);