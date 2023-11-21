/*
Задание 1. Совместная работа
Напишите программу которая на вход принимает два целых числа и проверяет
является ли первое число квадратом второго. 
*/
System.Console.Write("Введите первое число: ");
string num1String = Console.ReadLine();
int number1 = Convert.ToInt32(num1String);

System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
//int number1 = 25;
//int number2 = 6;

if (number1 == Math.Pow(number2, 2))
{
   Console.WriteLine("yes");
}
else
{
   Console.WriteLine("no");
}