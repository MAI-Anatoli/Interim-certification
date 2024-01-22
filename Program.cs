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

static string[] FilterArray(string[] inputArray)
    {
        
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];

        int index = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index] = item;
                index++;
            }
        }

        return resultArray;
    }

 static void PrintArray(string[] array)
    {
        Console.WriteLine("Отфильтрованный массив:");
        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }

}