﻿// Сдавать ссылкой на github
Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void f(int a, int b)
// {
//     Console.WriteLine (Math.Pow(a,b));
// }
// Console.Write ("Введи число a=");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введи число b=");
// int b = Convert.ToInt32(Console.ReadLine());
// f(a,b);


//=======================================================================================================================================
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write ("Введи число N=");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10) Console.WriteLine (N);
// else 
// {
//  int answer = 0;
//     while (N >0)
//     {
//         answer = answer +N % 10;
//         N /=10;
//     }
// Console.WriteLine(answer);
// }
//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
//  или так, через функцию (не понимаю как нужно по условию задачи).....

void f(int N)
{
if (N < 10) Console.WriteLine (N);
else 
{
 int answer = 0;
    while (N >0)
    {
        answer = answer +N % 10;
        N /=10;
    }
Console.WriteLine(answer);
}
}

Console.Write ("Введи число N=");
int N = Convert.ToInt32(Console.ReadLine());
f(N);



//=======================================================================================================================================
// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]
// 
// Console.Write ("Введи длину массива n=");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [n];
//     for(int i = 0; i < n; i++)
//     array[i] = new Random().Next();   //Next(-100,100)
// Console.WriteLine ($"[{string.Join(", ", array)}]");