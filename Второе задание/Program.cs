/*Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/

System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

void PrintSum(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов=[{summ}].");
    return;
  }
  PrintSum(M, N - 1, summ);
}
PrintSum(M, N, temp=0);