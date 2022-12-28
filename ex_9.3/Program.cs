// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AcFun(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return AcFun(m - 1, 1);
    else
        return AcFun(m - 1, AcFun(m, n - 1));
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = EnterData("Введите число: ");
int m = EnterData("Введите число: ");
Console.WriteLine(AcFun(m, n));


