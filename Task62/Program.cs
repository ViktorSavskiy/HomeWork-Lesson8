int row = 4; 
int columns = row;
int[,] matrix = new int[row, columns];
 
int[,] Matrix = CreateNewArray(matrix);
 
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
 
int[,] CreateNewArray(int[,] matr)
{
int num = 1;
int i = 0;
int j = 0;
 
while (num <= row * columns)
{
matrix[i, j] = num;
if (i <= j + 1 && i + j < row - 1)
++j;
else if (i < j && i + j >= row - 1)
++i;
else if (i >= j && i + j > row - 1)
--j;
else
--i;
++num;
}
return matrix;
}
