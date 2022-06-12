//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("введите целое число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int div = number % 2;

if (div == 0) Console.WriteLine("число четное");
else
{
    Console.WriteLine("число нечетное");
}