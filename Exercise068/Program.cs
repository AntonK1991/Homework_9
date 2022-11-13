// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Input(string data, string num)
{
    Console.Write(data);
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 0) 
    {
        Console.WriteLine("Число должно быть положительным! Повторите ввод!"); 
        Input($"Введите {num} неотрицательное число: ", "");
    }
    return n;
}

int FAkkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n > 0 && m == 0)
    {
        return FAkkerman(n - 1, 1);
    }
    return FAkkerman(n - 1, FAkkerman(n, m - 1));
}

int n = Input ("Введите первое неотрицательное число: ", "первое");
int m = Input ("Введите второе неотрицательное число: ", "второе");
int res = FAkkerman(n, m);
Console.WriteLine(res);