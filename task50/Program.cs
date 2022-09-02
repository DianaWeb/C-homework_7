/* Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7->такого числа в массиве нет */
System.Console.WriteLine("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число стоблцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 1, 9);
PrintMatrix(ourMatrix);
FindNumber(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
	int[,] matrix = new int[rowsCount, columnsCount];
	Random random = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = random.Next(leftRange, rightRange + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			System.Console.Write(matrix[i, j] + " ");
		}
		System.Console.WriteLine();
	}
}

void FindNumber(int[,] matrix)
{
	System.Console.WriteLine("Введите позицию элемента по строке: ");
	int findRow = Convert.ToInt32(Console.ReadLine());
	System.Console.WriteLine("Введите позицию элемента по столбцу: ");
	int findColumn = Convert.ToInt32(Console.ReadLine());

	if (findRow > m || findColumn > n)
	{
		System.Console.WriteLine("Такого числа в массиве нет.");
	}
	else System.Console.WriteLine($"Это число: {matrix[findRow - 1, findColumn - 1]}");
}