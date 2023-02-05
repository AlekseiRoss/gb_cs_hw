/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

using System;

bool digitArr(int n){
	if (n == 0) return true;
	if (n < 0) n = -n;

	var digits = new List<int>();

	for (; n != 0; n /= 10)
	digits.Add(n % 10);
	var arr = digits.ToArray();
	var normal_arr = arr;
	var len = arr.Length;
	Array.Reverse(arr);
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] == normal_arr[len - i - 1]) continue;
		else return false;

	}
	return true;
}


Console.WriteLine(digitArr(123321));

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53*/


double d3Distance(d3Point point1, d3Point point2)
{
	double distance = 0.0;

    for (int i=0; i < 3; i++)
	{
		distance += (point1.Coordinates[i] - point2.Coordinates[i]) * (point1.Coordinates[i] - point2.Coordinates[i]);
	}

	distance = Math.Sqrt(distance);

	return distance;
}

d3Point a = new d3Point(3, 6, 8);
d3Point b = new d3Point(2, 1, -7);
Console.WriteLine(d3Distance(a, b));

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

var cube = (int x) => x * x * x;
Console.WriteLine(cube(3));

// Класс 3d Point
class d3Point
{
	int[] coordinates = new int[3];

	public d3Point(int initX, int initY, int initZ)
	{
		this.coordinates[0] = initX;
		this.coordinates[1] = initY;
        this.coordinates[2] = initZ;
    }

	public int[] Coordinates
	{
		get
		{
			return coordinates;
		}
		set
		{
			coordinates = value;
		}
	}
}