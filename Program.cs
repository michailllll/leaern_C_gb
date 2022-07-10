// Задача 2:  программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write( "напишите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write( "введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
   Console.WriteLine( "a = " + number1 + " " + "b = " + number2  + " -> " + "max = " + number1);
else
   Console.WriteLine( "a = " + number1 + " " + "b = " + number2  + " -> " + "max = " + number2);
