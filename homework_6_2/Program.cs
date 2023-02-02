//Задать двумерный массив следующим правилом: Aₘₙ = m+n
void NewMatrix(int[,] matr)
{for (int m=0; m<matr.GetLength(0); m++)
{for (int n=0; n<matr.GetLength(1); n++)
{matr[m, n] = m + n;}}}

void PrintMatrix(int[,] matr)
{for (int i=0; i<matr.GetLength(0); i++)
{for (int j=0; j<matr.GetLength(1); j++)
{Console.Write($"{matr[i, j]} ");}
Console.WriteLine();}}

int n = 11; int m = 11;
int[,] matrix = new int[n, m];
NewMatrix(matrix);
PrintMatrix(matrix);