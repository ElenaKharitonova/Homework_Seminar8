// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int m, int n)//заполнение двумерного массива m x n
//случайными числами в границах 1/10
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[] array)//печать одномерного массива
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}");
    }
    System.Console.WriteLine();
}

void PrintArrayTwo(int[,] arrNums)//печать двухмерного массива
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]}");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]}");
        }
        System.Console.WriteLine("");
    }
}

int []SumElementsRow(int[,] array)
{
    int[] sumElements = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumElements[i]=sum;
    }
    return sumElements;
}

int FindMinValueIndex(int[] array)//нахождение индекса минимального 
//элемента массива
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            minIndex = i;
        }
    }
    return minIndex;
}

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
int[,] matrix = FillArray(m, n);
PrintArrayTwo(matrix);
int [] sumElementsRow = SumElementsRow(matrix);
int minSumIndex = FindMinValueIndex(sumElementsRow);
System.Console.Write("Массив сумм элементов строк:  ");
PrintArray(sumElementsRow);
System.Console.WriteLine($"{minSumIndex+1} строка");
System.Console.WriteLine();