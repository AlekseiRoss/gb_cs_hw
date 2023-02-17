/*Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Random random = new Random();

double[,] create2dArr(int m, int n)
{
	int minValue = -10;
	int maxValue = 10;
	double[,] arr = new double[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			arr[i, j] = Math.Round(random.NextDouble() * random.Next(minValue, maxValue + 1), 1);
		}
	}
	return arr;
}

Console.WriteLine("Задача 47");
int m = 3;
int n = 4;
double[,] created2dArray = create2dArr(m, n);
for (int i = 0; i < m; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write(created2dArray[i, j] + " ");
	}
	Console.WriteLine();
}

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет*/

void position(int pos)
{
	try
	{
        Console.WriteLine(created2dArray[pos / (m + 1), pos % n]);
    }
    catch (Exception e)
    {
        Console.WriteLine($"{pos} -> такого числа в массиве нет");
    }
}

Console.WriteLine("\nЗадача 50");
position(20);
position(11);

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

double[] meanColumn(int[,] arr)
{
	int n = arr.GetLength(0); // |
	int m = arr.GetLength(1); // -
	double[] meanCol = new double[m];

	for(int j = 0; j < m; j++)
	{
		meanCol[j] = 0;
        for (int i = 0; i < n; i++) meanCol[j] += arr[i, j];
		meanCol[j] /= n;
    }
    return meanCol;
}

Console.WriteLine("\nЗадача 52");
int[,] nums2 ={
	{ 0, 1, 2 },
	{ 3, 4, 5 } };
Console.WriteLine("[{0}]", string.Join(", ", meanColumn(nums2)));
