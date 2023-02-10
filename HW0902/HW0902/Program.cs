/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Random random = new Random();
int arr_len = 5;
int[] arr = new int[arr_len];
int minValue = 100;
int maxValue = 999;
for (int i=0; i<arr_len; i++)
{
	arr[i] = random.Next(minValue, maxValue + 1);
}

int countOfEven(int[] arr)
{
	int counter = 0;
	for(int i=0; i<arr.Length; i++)
	{
		if (arr[i]%2 == 0) counter++; 
	}
	return counter;
}

Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
Console.WriteLine($"number of even in arr = {countOfEven(arr)}" + '\n');

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0*/

for (int i = 0; i < arr_len; i++)
{
    arr[i] = random.Next(-100, 100 + 1);
}

int sumOfOdd(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) sum+=arr[i];
    }
    return sum;
}

Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
Console.WriteLine($"sum of odd in arr = {sumOfOdd(arr)}" + '\n');

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] doubleArr = new double[arr_len];

for (int i = 0; i < arr_len; i++)
{
    int rand_1 = random.Next(-100, 100 + 1);
    int rand_2 = random.Next(1, 100 + 1); // Чтобы не было деления на 0
    doubleArr[i] = (double)rand_1 / rand_2;
}

double diffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>max) max = arr[i];
        if (arr[i]<min) min = arr[i];
    }
    return max-min;
}

Console.WriteLine("doubleArr = [{0}]", string.Join(", ", doubleArr));
Console.WriteLine($"difference between max and min = {diffMaxMin(doubleArr)}");
