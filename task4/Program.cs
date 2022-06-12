//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Write("введите целое число1: ");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.Write("введите целое число2: ");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

Console.Write("введите целое число3: ");
string input3 = Console.ReadLine();
int number3 = Convert.ToInt32(input3);

int max = number1;

if (number2 > number1 && number2 > number3) max = number2;
else
{
    if (number3 > number1)
        max = number3;
}

Console.WriteLine("max= " + max);
