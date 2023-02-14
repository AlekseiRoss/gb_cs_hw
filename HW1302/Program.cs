/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
using System.Diagnostics.Metrics;

int positive()
{
    int M = 6;
    int[] num_arr = new int[M];
    int counter = 0;
    Console.WriteLine("Enter numbers");
    for (int i = 0; i < M; i++)
    {
        num_arr[i] = int.Parse(Console.ReadLine());
        if (num_arr[i] > 0) counter++;
    }
    return counter;
}

Console.WriteLine($"number of positive numbers: {positive()}");

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

void intersectionPoint()
{
    Console.WriteLine("Enter b1, k1, b2, k2:");
    double[] num_arr = new double[4];
    for (int i = 0; i < 4; i++) num_arr[i] = int.Parse(Console.ReadLine());
    double x = (num_arr[2] - num_arr[0]) / (num_arr[1] - num_arr[3]);
    double y = num_arr[1] * x + num_arr[0];
    Console.WriteLine($"intersection point: ({x}, {y})");
}

intersectionPoint();