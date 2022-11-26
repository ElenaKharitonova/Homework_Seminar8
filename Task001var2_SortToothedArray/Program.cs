// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Попробовала работать с зубчатыми массивами. Не смотря на то, 
//что при задании фиксированного кол-ва столбцов, 
//массив перестает быть зубчатым.
//Не смогла найти, почему программа не воспринимает квадратные массивы.

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[][] SetStepArray(int m, int n)
{
    int[][] array = new int[m][];
    for (int j = 0; j < n - 1; j++)
    {
        array[j] = new int[n];
    }
    return array;
}

void FillRandomStepArray(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            array[i][j] = new Random().Next(1,10);
        }
    }
}

void PrintStepArray(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            Console.Write(array[i][j] + "\t");
        }
        Console.WriteLine();
    }
}


void Swap (int []  array, int j1, int j2 )
{
    int temp = array[j1];
    array[j1] = array[j2];
    array[j2] = temp;
}

void SortBubble(int[] array)
{
    for (int count = 0; count < array.Length-1; count++)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < array[i+1])
            {Swap (array,i,i+1);}
        }
    }
}

void SortBubbleStepArray(int[][] array)
{
    foreach(int [] tempArray in array)
    {
        SortBubble(tempArray);
    }
  
}

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
int[][] matrixStep = SetStepArray(m, n);
FillRandomStepArray(matrixStep);
PrintStepArray(matrixStep);
System.Console.WriteLine();
SortBubbleStepArray(matrixStep);
PrintStepArray(matrixStep);