// программа сравнивает число и квадрат другого числа
Console.Write( "введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write( "введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
    Console.WriteLine( "a = " + number1 + " " + "b = " + number2  + " " + "да");
else
    Console.WriteLine( "a = " + number1 + "b = " + number2 + "нет");
