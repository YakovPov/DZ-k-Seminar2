﻿// __________________Задача 10_______________________________________ 
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num=Convert.ToInt32(Console.ReadLine());

// int num2= ((num/10)%10);

// Console.WriteLine(num2);


// _________________________Задача 13_____________________________________________________
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());


// if (num/100==0)
// {
//    Console.WriteLine("Третей цифры нет");
// }
// else
// {
//     while (num>1000)
//     {
//         num= num/10;
//     }
//     num= num%10; 
//     Console.WriteLine(num);  
// }


// ______________________________Задача 15_____________________________
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели");
int num=Convert.ToInt32(Console.ReadLine());
if (num>=1 && num<=5)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}