/*Задача 3: * Найдите максимальное значение в матрице по каждой строке, 
получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2*/


int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillRandomMatrix(int line, int column, int argMin, int argMax) // наполняем матрицу случайными значениями по заданным параметрам и выводим на экран
{
    int[,] matrix = new int[line, column];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(argMin, argMax);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int SumMaxLineMatrix(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int max = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (max < matr[i, j]) max = matr[i, j];
        }
        sum = sum + max;
    }
    return sum;
}

int SumMinColumnMatrix(int[,] matr, int argMax)
{
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int min = argMax;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            if (matr[i, j] < min) min = matr[i, j];
        }
        sum = sum + min;
    }
    return sum;
}

int line = Prompt("Укажите количество строк матрицы >- ");
int column = Prompt("Укажите количество столбцов матрицы >- ");
int min = Prompt("Укажите диапазон значений матрицы: от >- ");
int max = Prompt("до (включительно) >- ");

int[,] matrix = FillRandomMatrix(line, column, min, max + 1);
PrintMatrix(matrix);
int sumMax = SumMaxLineMatrix(matrix);
int sumMin = SumMinColumnMatrix(matrix, max);

System.Console.WriteLine($"Сумма максимумов в строках {sumMax}");
System.Console.WriteLine($"Сумма минимумов в столбцах {sumMin}");
System.Console.WriteLine($"Разница между максимумами в строках и  минимумами в столбцах равна {sumMax - sumMin}");