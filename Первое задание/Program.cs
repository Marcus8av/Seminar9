/*Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/
System.Console.WriteLine("Введите значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write($"Натуральное число:[{count}], ");
}

PrintNumber(n, count);
System.Console.WriteLine();

