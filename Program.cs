/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/



using System;

string[] Array;
Console.WriteLine("Введите массив строк через запятую");
string line = Console.ReadLine();
Array = line.Split(',');
var Result = new string[Array .Length];
var realSize = 0;
foreach (var value in Array )
{
    if (value.Length <= 3)
    {
        Result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine("Новый массив:");
Console.WriteLine(string.Join(Environment.NewLine, Result, 0, realSize));
Console.ReadKey(true);