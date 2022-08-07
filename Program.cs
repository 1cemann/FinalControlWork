//Написать программу, которая из имеющегося массива строк формирует массив из строк длинна которых меньше либо равна 3.
using System;
using static System.Console;
Clear();


string[] M;
WriteLine("Введите массив строк через пробел");
string unknown = ReadLine();
M = unknown.Split(' ');
var result = new string[M .Length];
var size = 0;
foreach (var value in M )
{
    if (value.Length <= 3)
    {
    result[size] = value;
    size++;
    }
}
WriteLine(string.Join(" ", result, 0, size));
