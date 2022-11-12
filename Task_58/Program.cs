/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,]CreateArray(int num1, int num2)
{
    int[,]array=new int[num1,num2];
    Random rnd =new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i,j]=rnd.Next(1,9);
      }  
    }
    return array;
}
void PrintArray(int[,]array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i,j]} ");
      }  
      Console.WriteLine();
    }
    Console.WriteLine();
}
int[,]MultiplyMatrix (int[,]matrix1, int[,]matrix2)
{
int[,]matrixC= new int[matrix1.GetLength(0),matrix2.GetLength(1)];;
if(matrix1.GetLength(1)!= matrix2.GetLength(0))
{
  Console.WriteLine("Матрица 1 должна иметь количество столбцов равное количеству строк матрицы 2");
}
else
{
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      int num = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        num = num+matrix1[i,k]*matrix2[k,j];
      }
      matrixC[i,j] = num;
    }
  }
}
Console.WriteLine("Результирующая матрица будет:");
return matrixC;
}
Console.WriteLine("Даны две матрицы");
int[,] matrixA = CreateArray(2,3);
int[,] matrixB = CreateArray(3,4);
PrintArray(matrixA);
PrintArray(matrixB);
int[,] matrixC = MultiplyMatrix(matrixA,matrixB);
PrintArray(matrixC);
