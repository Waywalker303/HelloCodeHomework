// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
// Например, задан массив:


int line = 4; int column = 4;
int[,] array = new int[line, column];

ArrayRandomEvenPrint(array);

ArrayArithmeticMeanColumn(array);


void ArrayArithmeticMeanColumn(int[,] array)
{
Console.WriteLine($"Cреднее арифметическое в столбце:");
for (int i = 0; i < column; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < line; j++)
  {
    arithmeticMean += array[j, i];
  }
  arithmeticMean = arithmeticMean / line;
  Console.WriteLine($"№ {i+1} = {arithmeticMean}");
}
}

void ArrayRandomEvenPrint(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToInt32(new Random().Next(2, 9));
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





