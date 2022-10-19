/*Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] Array(int num) // преобразовывает десятичное число в двоичное.
{
    int[] array = new int[10];

    for (int i = 1; num > 0 || num % 2 != 0; i++)
    {
        array[10 - i] = num % 2;
        num = num / 2;
    }
    return array;
}

void PrintArray(int[] array) // выводим массив на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int a = Prompt("Введите число >- ");
PrintArray(Array(a));
