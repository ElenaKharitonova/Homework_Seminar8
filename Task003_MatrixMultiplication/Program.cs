// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// По определению произведения матриц можно перемножать только такие матрицы,
// у которых число столбцов в первой матрице равно числу строк во второй матрице.


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

int [,]MatrixMultiplication(int[,] array1,int[,] array2)
//функция перемножения матриц 
//Необходимое условие array.GetLenght(1)=array.GetLenght(0) 
//Число столбцов 1-ой=числу строк второй
{
    int[,] multyArray = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < multyArray.GetLength(0); i++)
    {
        for (int j = 0; j < multyArray.GetLength(1); j++)
        {
           multyArray[i,j]=0;
           for (int k = 0; k < array2.GetLength(0); k++) 
           {
             multyArray[i,j] = multyArray[i,j] + array1[i,k] * array2[k,j];
           }
        }  
    }
    return multyArray;
}


System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк первой матрицы): ");
System.Console.WriteLine("Введите n (кол-во столбцов первой матрицы равное ");
int n = PromptInt("кол-ву строк второй матрицы): ");
int l = PromptInt("Введите l (кол-во столбцов второй матрицы): ");
int[,] matrix1 = FillArray(m, n);
int[,] matrix2 = FillArray(n, l);
PrintArrayTwo(matrix1);
System.Console.WriteLine();
PrintArrayTwo(matrix2);
System.Console.WriteLine();

int [,] multyMatrix = MatrixMultiplication(matrix1,matrix2);
System.Console.WriteLine("Произведение двух матриц:  ");
PrintArrayTwo(multyMatrix);
System.Console.WriteLine();