﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число N: ");
double n = Convert.ToDouble(Console.ReadLine());
int count =1;
while (count < n)
{
   Console.Write(Math.Pow((count), 3) +", ");
   count++;
}
Console.Write(Math.Pow((count), 3));