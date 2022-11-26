// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void PrintArray(int[,] arrNums)//печать двухмерного массива
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


void Swap (int [,]  array, int i, int j1, int j2 )
{
    int temp = array[i,j1];
    array[i,j1] = array[i,j2];
    array[i,j2] = temp;
}

void SortBubble(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1)-j-1; l++)
            {
            if (array[i,l] < array[i,l+1])
            {Swap (array,i,l,l+1);}
            }
        }
    }
}

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
int[,] matrix = FillArray(m, n);
PrintArray(matrix);
System.Console.WriteLine();
SortBubble(matrix);
PrintArray(matrix);