//Показать двумерный массив размером m×n заполненный вещественными числами
void PrintMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

void FillMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{matr[i, j] = new Random().Next(10, 100);}}}

int[,] matrix = new int[5, 10];
PrintMatrix(matrix);
FillMatrix(matrix);
Console.Write("-----------------------------");
Console.WriteLine();
PrintMatrix(matrix);