// Задача 64: Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int Input(string data)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Значение должно быть больше 0");
    return n;
}

int NumList(int n, int m)
{
    if (n < m) return 0;
    else 
    {
        System.Console.Write($"{n,3}");
        NumList(n-1,m);
    }
    return n; 
}

int n = Input ("Введите значение: ");
int m = 1;
System.Console.Write("Натуральные числа от заданного числа до 1:");
NumList(n, m);
System.Console.WriteLine();
