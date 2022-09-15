Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[row, columns];
 
int[,] Matrix = CreateArray(matrix);
 
PrintArray(Matrix);
Console.WriteLine("");
Ordering(Matrix);
Console.WriteLine("Упорядоченная по строкам матрица");
PrintArray(Matrix);
Console.WriteLine("");
 
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
 
void Ordering (int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
for (int j = 0; j < matr.GetLength(1)-1; j++)
{
for (int z = 0; z < matr.GetLength(1) - 1; z++)
{
if (matr[i,z] < matr[i,z + 1])
{
int temp = 0;
temp = matr[i,z];
matr[i,z] = matr[i,z + 1];
matr[i,z + 1] = temp;
}
}
}
}