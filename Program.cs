using System;

class Program
{

static void Main()
    {
        Console.Write("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' ');

        string[] resultArray = FilterArray(inputArray);

        PrintArray(resultArray);
    }





}