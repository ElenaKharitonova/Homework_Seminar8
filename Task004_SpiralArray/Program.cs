//Напишите программу, которая заполнит спирально квадратный массив. 
int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] SpiralFillArray(int[,] array, int m) //заполнение двумерного 
//квадратного массива m x m попорядку
{
    int i = 0;
    int j = 0;
    int k = 1;
    while (k <= m * m)
    {
        array[i, j] = k;
        k++;
        if (i <= j + 1 && i + j < m - 1)
        {
            j++;
        }
        else 
        {
            if (i < j && i + j >= m - 1)
            {
                i++;
            }
            else 
            {
                if (i >= j && i + j > m - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
             }    
        }
    }             
    return array;
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

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Задайте размерность квадратного массива m: ");
int[,] matrix = new int[m,m];
int[,] spiralMatrix = SpiralFillArray(matrix, m);
PrintArrayTwo(spiralMatrix);