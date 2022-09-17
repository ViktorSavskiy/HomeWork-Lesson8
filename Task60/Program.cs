Console.WriteLine("Введите число строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число z: ");
int z = int.Parse(Console.ReadLine());
int[,,] matrix = new int[row, columns, z];
 
int[,,] Matrix = CreateArray(matrix);
 
PrintArray(Matrix);
Console.WriteLine("");


 
void PrintArray(int[,,] matr)
{
 
for (int i = 0; i < matr.GetLength(0); i++)
{

for (int j = 0; j < matr.GetLength(1); j++)
{
   for (int k = 0; k < matr.GetLength(2); k++)
Console.Write(matr[i, j, k] + " ");
}
Console.WriteLine("");
}
}
 
int[,,] CreateArray(int[,,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
    for (int k = 0; k < matr.GetLength(2); k++)
{
    matr[i, j, k] = new Random().Next(10, 100);
}
}
}
return matr;
}
