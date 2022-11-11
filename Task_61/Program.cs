/* Задача 61: Задайте двумерный массив (4x4). Напишите программу, 
которая заполнит его по спирали.*/

int[,] array = new int[4,4];
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
int[,] FillArray(int[,]array)
{
  int length0 = 0;
  int i=length0;
  int j=length0;
  int length = array.GetLength(0)-1;
  int next = 0;
 while (length!=0)
 { 
  while (j<length)
  {
    next = next+1;
    array[i,j]=next;
    j++;
  }  
  while (i<length)
  {
    next = next+1;
    array[i,j]=next;
    i++;
  }
  while (j>length0)
  {
    next = next+1;
    array[i,j]=next;
    j--;
  }  
  length0++;
  while (i>length0)
  {
    next = next+1;
    array[i,j]=next;
    i--;
  }
  length--;
 } 
  next = next+1;
  array[i,j]=next;
  return array;
}
  
PrintArray(array);
PrintArray(FillArray(array));
