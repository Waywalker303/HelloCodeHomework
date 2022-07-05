/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int [,] array2D = new int [4,6];
Console.Clear();
ArrayRandomEvenPrint(array2D);

int minSumLine = 0;
int sumLine = SumLineElements(array2D, 0);
for (int i = 1; i < array2D.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array2D, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine("");
Console.WriteLine($"Cтрокa {minSumLine+1} с наименьшей суммой {sumLine} элементов ");
Console.WriteLine("");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
        {
        sumLine += array[i,j];
        }
    return sumLine;
}


void ArrayRandomEvenPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(10, 100));
        }
    
    }
    PrintArray(array);
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Enter(string n)
{
        Console.WriteLine("");
}