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
    int summ = 0;
    if (m < n) return 0;
    else summ = n + SumList(n+1,m);
    return summ; 
}

int n = Input ("Введите начальное значение: ");
int m = Input ("Введите конечное значение: ");
int res = SumList(n, m);
System.Console.Write("Сумма натуральных элементов в заданном промежутке: ");
System.Console.WriteLine(res);
