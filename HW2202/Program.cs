/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void descNaturals(int n)
{
	if (n > 1)
	{
		Console.Write($"{n}, ");
		descNaturals(--n);
	}
	else Console.WriteLine("1");
}

descNaturals(5);
descNaturals(20);

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

int sumOfNaturals(int m, int n)
{
	if (n == m) return m;
    return n + sumOfNaturals(m, --n);
}

Console.WriteLine(sumOfNaturals(4, 8));


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/

int Ackermann(int m, int n)
{
	if (m == 0) return n + 1;
	if (n == 0 && m > 0) return Ackermann(m - 1, 1);
	return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine(Ackermann(2, 3));
Console.WriteLine(Ackermann(3, 2));