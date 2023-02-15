// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int f(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return f(n - 1, 1);
    else
      return f(n - 1, f(n, m - 1));
}

Console.Write("Введите число m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
