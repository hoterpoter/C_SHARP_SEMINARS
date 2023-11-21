/*
Напишите программу, которая на вход принимает
целое число N, а на выходе показывает все целые
числа в промежутке от -N до N.
Примеры
4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
2 => -2, -1, 0, 1, 2
*/

System.Console.WriteLine("Input: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Number => {number}");

int index = -number;

while (index <= number)
{
   System.Console.Write(index + " ");
   index++;
}