/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка
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

int[] SummRowsNumbersCounter (int[,]array)
{
    int[]array1 = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i,j];            
        }
        array1[i] = summ;
    }
    return array1;
}
void IndexMaxResearch (int[]array)
{
    int min = array[0];
    int indexMin = 1;
    for (int k = 1; k < array.Length; k++)
    {
        if (array[k]<min)
        {
            min=array[k];
            indexMin = k+1;
        }
    }
    Console.WriteLine($"{indexMin} строка");
}

int[,] matrix = CreateArray(6,3);
PrintArray(matrix);
int[]array = SummRowsNumbersCounter(matrix);
IndexMaxResearch(array);

