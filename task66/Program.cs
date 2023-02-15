//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

int f(int m, int n)
{
int sum=n;
if(n==m)
return sum;
return sum+f(m, n-1);
}

Console.Write("Введите число m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));

