//В матрице чисел найти сумму элементов главной диагонали
void FillMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{matr[i, j] = new Random().Next(0, 10);}}}

void PrintMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

int SumMatrix(int[,] matr)
{int sum = 0;
for (int i=0; i<matr.GetLength(0); i++)
{sum += matr[i, i];}
return sum;}

int[,] matrix = new int[10, 10];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"sum of main diagonal elements: " + SumMatrix(matrix));