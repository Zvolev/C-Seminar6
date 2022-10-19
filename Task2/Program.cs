/*
Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/


int[] RandomArrGen(int len) // создает и рандомно наполняет массив заданной длины и выводит его на печать
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(1, 10);
        System.Console.Write($"{arr[i]} "); 
    }
    return arr;
}

bool CheckTraingle( int[] arr) //проверяет, может ли существовать треугольник с сторонами такой длины
{
    if(arr[0] + arr[1] < arr[2]) return false;
    if(arr[0] + arr[2] < arr[1]) return false;
    if(arr[2] + arr[1] < arr[0]) return false;
    return true;
}

int[] triangle = RandomArrGen(3);
System.Console.WriteLine(CheckTraingle(triangle));

