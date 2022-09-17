Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[row, columns];
 int[,] matrixTwo = new int[row, columns];
 int[,] matrixThree = new int[row, columns];

int[,] Matrix = CreateArray(matrix);
int[,] MatrixTwo = CreateArrayTwo(matrixTwo);

Console.WriteLine("Вывод первой матрицы: ");
Console.WriteLine("");
PrintArray(Matrix);
Console.WriteLine("");

Console.WriteLine("Вывод второй матрицы: ");
Console.WriteLine("");
PrintArray(MatrixTwo);
Console.WriteLine("");

Console.WriteLine("Вывод результата перемножения двух матриц: ");
MatrixProduct(matrix, matrixTwo, matrixThree);
PrintArray(matrixThree);


 
void PrintArray(int[,] matr)
{
 
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write(matr[i, j] + " ");
}
Console.WriteLine("");
}
 
}
 
int[,] CreateArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(0, 10);
}
}
return matr;
}

int[,] CreateArrayTwo(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
matr[i, j] = new Random().Next(0, 10);
}
}
return matr;
}

void MatrixProduct(int[,] matrix, int[,] matrixTwo, int[,] matrixThree)
{
    for (int i = 0; i < matrixThree.GetLength(0); i++)
 {
    for (int j = 0; j < matrixThree.GetLength(1); j++)
    {

    int sum = 0; 
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        sum += matrix[i, k]*matrixTwo[k, j];
      }
      matrixThree [i,j] = sum;
    }
 }
}