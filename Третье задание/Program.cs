/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/
System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int functionAkkererman = Akker(M, N);

int Akker(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akker(M - 1, 1);
  else return Akker(M - 1, Akker(M, N - 1));
}
System.Console.WriteLine($"Функция Аккермана ({M};{N}) = {functionAkkererman}. ");

