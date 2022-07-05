/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/

Console.Clear();
Console.WriteLine($"Введите размеры матриц:");
int lineMatrix = Input("Введите число строк первой и второй матрицы: ");
int columnMatrix = Input("Введите число столбцов первой и второй матрицы: ");


int[,] firstMartrix = new int[lineMatrix, columnMatrix];
ArrayRandom(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[lineMatrix, columnMatrix];
ArrayRandom(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[lineMatrix,columnMatrix];

MatrixSum(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintArray(resultMatrix);

void MatrixSum(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void ArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10,50);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}