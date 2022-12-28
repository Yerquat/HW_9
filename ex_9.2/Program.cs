// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Summ(int m, int n)
{
    if (m > n) return 0;
    if (m == n) return (m);
    else return ((m + n) + Summ(m + 1, n - 1));
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterData("Введите число m: ");
int n = EnterData("Введите число n: ");
Console.WriteLine($"Сумма чисел от {m} до {n} равна: " + Summ(m, n));