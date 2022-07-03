/*Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int line = Input("Введите количество строк: ");
int column = Input("Введите колличество столбцов: ");

//int line = 4; int column = 4;
double[,] arrayUser = new double[line, column];

ArrayRandomFactional(arrayUser);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void ArrayRandomFactional(double[,] arrayUser)
{
for (int i = 0; i < arrayUser.GetLength(0); i++)
{
    for(int j = 0; j < arrayUser.GetLength(1); j++)
    {
        arrayUser[i, j] = Convert.ToDouble(new Random().Next(-10000, 10000)) / 100;
    }
    
}
PrintArray(arrayUser);
}

void PrintArray(double[,] array)
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





