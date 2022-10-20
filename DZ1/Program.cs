/*Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь. Разделить ввод данных, от расчета данных (Одна функция вводит данные,
другая функция подсчитывает количество положительных)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputNam(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = Prompt("Введите число -> ");
    }
    return arr;
}

int AmountOfNumbers(int[] arr, int len)
{
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        if (arr[i] > 0)
        {
            sum ++;
        }
    }
    return sum;
}

int len = Prompt("Количество чисел на проверку => ");
int[] scroll = InputNam(len);
int amount = AmountOfNumbers(scroll, len);
System.Console.WriteLine(amount);
