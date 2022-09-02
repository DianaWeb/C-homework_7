/* Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3. */
System.Console.WriteLine("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число стоблцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 1, 9);
PrintMatrix(ourMatrix);
arithmeticMeanNumbers(ourMatrix);

void arithmeticMeanNumbers(int[,] matrix)
{
	double[] arr = new double[matrix.GetLength(1)];
	double sum = 0;
	double arithmeticMean;
	// System.Console.Write("Среднее арифметическое каждого столбца: ");
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			sum = sum + matrix[i, j];
		}
		arithmeticMean = (double)(sum / (matrix.GetLength(0)));
		// System.Console.Write(arithmeticMean + "; ");
		arr[j] = arithmeticMean;
		sum = 0;
	}
	System.Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", arr)}.");
}
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

