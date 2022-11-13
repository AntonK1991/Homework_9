// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

int Input(string data)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int SumList(int n, int m)
{
    if (m == n-1) return 0;
    else return n + SumList(n+1,m);
}

int n = Input ("Введите начальное значение: ");
int m = Input ("Введите конечное значение: ");
int res = SumList(n, m);
System.Console.Write("Сумма натуральных элементов в заданном промежутке: ");
System.Console.WriteLine(res);
