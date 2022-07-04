//  Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if  (num > 0 && num <= 5) Console.WriteLine("На работу");
    else
    
    if (num<=7 && num>0) Console.WriteLine("Выходной");
    else
           
Console.WriteLine("Дня не существует");
            

