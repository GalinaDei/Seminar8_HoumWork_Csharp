/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int [,] ReversArray (int[,]array)
{
    int[,]array1 = new int[array.GetLength(0),array.GetLength(1)];
      for (int i = 0; i < array1.GetLength(0); i++)
      {
        for (int j = 0; j < array1.GetLength(1); j++)
         {
           array1[i,j] = array[i,array.GetLength(1)-1-j];
         }  
      }
return array1;
}
int[,] matrix = CreateArray(4,6);
PrintArray(matrix);
int[,] matrixReversed = ReversArray(matrix);
PrintArray(matrixReversed);