﻿/*Задача 3: * Найдите максимальное значение в матрице по каждой строке, 
получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2*/

int InputArraySize(string message) // запрос, ввод  и проверка размера массива 
{
    Console.Write(message);
    int length = Convert.ToInt32(Console.ReadLine());
    if (length <= 0)
        Console.Write("Недопустимый размер массива");
    else
        Console.WriteLine();
    return length;
}

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateRandomArray(int argLength = 2, int argMin = 0, int argMax = 1) // создаем массив и наполняем его случайными значениями по заданным параметрам и выводим на экран
{
    int[] array = new int[argLength];

    Random rand = new Random();
    for (int i = 0; i < argLength; i++)
    {
        array[i] = rand.Next(argMin, argMax);
        //System.Console.WriteLine(array[i]);
    }
    return array;
}

int SumNumbersEvenElements(int[] array) //находит сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array) // выводим массив на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


int len = InputArraySize("Укажите размер массива >- ");
int min = Prompt("Укажите диапазон значений массива: от >- ");
int max = Prompt("до (включительно) >- ");
int[] array = CreateRandomArray(len, min, max - 1); // создаем массив по заданным параметрам
PrintArray(array); // выводим массив на печать
System.Console.WriteLine();
System.Console.WriteLine($"сумму элементов, стоящих на нечётных позициях {SumNumbersEvenElements(array)}");
 // выводим количество нечётных чисел в массиве на печать