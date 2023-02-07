/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16*/

int pow(int number, byte power)
{
    int num = 1;
    for (int i = 0; i < power; i++) num *= number;
    return num;
}

Console.WriteLine(pow(2, 3));

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int sumOfDigits(int number)
{
    int sum = 0;
    number = Math.Abs(number);

    for (; number != 0; number /= 10) sum += number % 10;

    return sum;
}

Console.WriteLine(sumOfDigits(-999));

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]*/

void intArray(params int[] x)
{
    Console.WriteLine("[{0}]", string.Join(", ", x));
}

intArray(1, 2, 3, 4, 5, 6, 7, 8);
