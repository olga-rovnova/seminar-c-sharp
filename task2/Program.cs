﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("введите первое целое число: ");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.Write("введите второе целое число: ");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

int max = number1;
if (number2 > number1) max = number2;
Console.WriteLine("max= " + max);
