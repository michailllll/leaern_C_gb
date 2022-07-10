// Задача 2:  программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.Write( "напишите число 1: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write( "введите число 2: ");
//int number2 = Convert.ToInt32(Console.ReadLine());

//if (number1 > number2)
  // Console.WriteLine( "a = " + number1 + " " + "b = " + number2  + " -> " + "max = " + number1);
//else
  // Console.WriteLine( "a = " + number1 + " " + "b = " + number2  + " -> " + "max = " + number2);

//Задача 4:  программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Console.Write( "напишите число 1: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write( "введите число 2: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.Write( "введите число 3: ");
//int number3 = Convert.ToInt32(Console.ReadLine());

//if (number1 > number2)
  // if (number1 > number3)
   //Console.WriteLine( number1 + "," + number2  + "," + number3 + "," + " -> " + number1);
   //else
   //Console.WriteLine( number1 + "," + number2  + "," + number3 + "," + " -> " + number3);
//else
  // if (number2 > number3)
   //Console.WriteLine( number1 + "," + number2  + "," + number3 + "," + " -> " + number2);
   //else
   //Console.WriteLine( number1 + "," + number2  + "," + number3 + "," + " -> " + number3);


   //Задача 6: программу, которая на вход принимает число и выдаёт, является ли число чётным

//Console.Write( "напишите число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//if (number1 % 2 == 0)
  // Console.WriteLine( number1  + " -> " + "да");
//else
  // Console.WriteLine( number1  + " -> " + "нет");

//Задача 8: программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write( "напишите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbercount = 1;
string vvedenoe = Convert.ToString(number);
while (numbercount < number)
{
  numbercount = numbercount + 1;
      if (numbercount % 2 == 0)
      //Console.WriteLine( number  + " -> " + numbercount);
      Console.Write(numbercount + " ,");
      
      
}




 