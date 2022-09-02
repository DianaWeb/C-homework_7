/* Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
System.Console.WriteLine("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число стоблцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] ourMatrix = GetMatrix(m, n);
PrintMatrix(ourMatrix);
double[,] GetMatrix(int rowsCount, int columnsCount/* , int leftRange, int rightRange */)
{
	double[,] matrix = new double[rowsCount, columnsCount];
	Random random = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = random.NextDouble();
		}
	}
	return matrix;
}

void PrintMatrix(double[,] matrix)
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