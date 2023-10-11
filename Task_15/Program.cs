﻿/*
Задача 15: Напишите программу, которая принимает
 на вход цифру, обозначающую день недели, 
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели и мы скажем, является ли он выходным");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 7)
{
    Console.WriteLine("Не может быть такого дня недели!");
    Console.WriteLine("Введите цифру заново");
    return;
}

if (number < 6)
{
    Console.WriteLine("Работай, сегодня не выходной");
}

else
    Console.WriteLine("Отдыхай, сегодня выходной");