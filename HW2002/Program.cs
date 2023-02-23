/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;
using System.Collections;
using System.Collections.Generic;

Random random = new Random();
int[,] create2dArr(int m, int n)
{
	int minValue = 0;
	int maxValue = 9;
	int[,] arr = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			arr[i, j] = random.Next(minValue, maxValue + 1);
		}
	}
	return arr;
}

int size = 4;
int[,] myArr = create2dArr(size, size);
void show2dArr(int[,] arr)
{
	int lines = arr.GetLength(0);
	int columns = arr.GetLength(1);
	for (int i = 0; i < lines; i++)
	{
		for (int j = 0; j < columns; j++)
			if (arr[i, j]<10) Console.Write("0" + arr[i, j] + " ");
			else Console.Write(arr[i, j] + " ");
		Console.WriteLine();
	}
}

int[,] sortArrLines(int[,] ar)
{
	int lines = ar.GetLength(0);
	int columns = ar.GetLength(1);
	int[,] arr2d = new int[lines, columns];
	int[] arr = new int[columns];
	for (int i = 0; i < lines; i++)
	{
		for (int j = 0; j < columns; j++)
			arr[j] = ar[i, j];
		Array.Sort(arr);
		Array.Reverse(arr);
		for (int k = 0; k < columns; k++)
			arr2d[i, k] = arr[k];
	}
	return arr2d;
}

Console.WriteLine("Задача 54");
show2dArr(myArr);
Console.WriteLine();
show2dArr(sortArrLines(myArr));


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

void minLineSum(int[,] ar)
{
	int lines = ar.GetLength(0);
	int columns = ar.GetLength(1);
	int[] linesSumArr = new int[lines];
	for (int i = 0; i < lines; i++)
	{
		for (int j = 0; j < columns; j++)
			linesSumArr[i] += ar[i, j];
	}
	int min = linesSumArr[0];
	int index = 0;
	for (int i = 1; i < lines; i++)
	{
		if (linesSumArr[i] < min)
		{
			min = linesSumArr[i];
			index = i;
		}
	}
	index++;
	Console.WriteLine("[{0}]", string.Join(", ", linesSumArr));
	Console.WriteLine(index + " строка");
}

Console.WriteLine("\nЗадача 56");
minLineSum(myArr);

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("\nЗадача 58");
int[,] matrix1 = create2dArr(2, 2);
Console.WriteLine("Matrix 1:");
show2dArr(matrix1);
int[,] matrix2 = create2dArr(2, 2);
Console.WriteLine("Matrix 2:");
show2dArr(matrix2);

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
	if (matrixA.GetLength(1) != matrixB.GetLength(0))
	{
		throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
	}

	var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

	for (var i = 0; i < matrixA.GetLength(0); i++)
	{
		for (var j = 0; j < matrixB.GetLength(1); j++)
		{
			matrixC[i, j] = 0;

			for (var k = 0; k < matrixA.GetLength(1); k++)
			{
				matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
			}
		}
	}
	return matrixC;
}

Console.WriteLine("Result matrix:");
show2dArr(MatrixMultiplication(matrix1, matrix2));

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/

void create3dArr(int m, int n, int o)
{
	int minValue = 10;
	int maxValue = 99;
	int[,,] arr = new int[m, n, o];
	int[] generatedNumbers = new int[m * n * o];
	HashSet<int> genNum = new HashSet<int>();
	while (genNum.Count() < m * n * o)
	{
		genNum.Add(random.Next(minValue, maxValue + 1));
	}
	generatedNumbers = genNum.ToArray();
	int count = 0;
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
		{
			for (int k = 0; k < o; k++)
			{
				arr[i, j, k] = generatedNumbers[count++];
				Console.Write(arr[i, j, k] + $"({i},{j},{k})" + " ");
			}
			Console.WriteLine();
		}

}
Console.WriteLine("\nЗадача 60");
create3dArr(2, 2, 2);

/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] createSpiral2dArr(int n)
{
    var result = new int[n, n];
	int currentChar = 1;
    for (int padding = 0; padding < n / 2; padding++)
    {
        for (int j = padding; j < n - padding; j++)
            result[padding, j] = currentChar++;

        for (int i = padding + 1; i < n - padding - 1; i++)
            result[i, n - padding - 1] = currentChar++;
       
        for (int j = n-padding-1; j > padding; j--)
            result[n - padding - 1, j] = currentChar++;
        for (int i = n - padding - 1; i > padding + 1; i--)
            result[i, padding] = currentChar++;

        result[padding + 1, padding] = currentChar++;
    }
    if (n % 2 != 0 && result[0, 0] == 1)
        result[n / 2, n / 2] = currentChar;

    return result;
}

Console.WriteLine("\nЗадача 62");
show2dArr(createSpiral2dArr(4));
