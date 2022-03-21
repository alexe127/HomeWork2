// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число №1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2) 
Console.WriteLine(number1 + " квадрат числа " + number2 );
else if (number2 == number1 * number1) 
Console.WriteLine(number2 + " квадрат числа " + number1 );
else Console.WriteLine("числа не являются квадратами");