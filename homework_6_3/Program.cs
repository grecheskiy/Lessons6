//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{matr[i, j] = new Random().Next(10, 100);}}}

void PrintMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

void ReplacMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{if ((i % 2 == 0) && (j % 2 == 0))
{matr[i, j] = matr[i, j] * matr[i, j];}}}}

int[,] matrix = new int[10, 10];
FillMatrix(matrix);
PrintMatrix(matrix);
ReplacMatrix(matrix);
Console.Write("-----------------------------");
Console.WriteLine();
PrintMatrix(matrix);