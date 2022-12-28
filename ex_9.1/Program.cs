﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumber(int n) 
{ 
    if (n == 1) Console.WriteLine(n);  
    else  
    { 
        Console.Write($"{n}, "); 
        NaturalNumber(n - 1);
         
    } 
} 

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = EnterData("Введите число: ");
NaturalNumber(n);

