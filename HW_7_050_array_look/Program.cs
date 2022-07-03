/*Задача 50: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int coordinateI = Input("Введите первую координату: ");
int coordinateJ = Input("Введите вторую координату: ");
int numberUser = Input("Введите число: ");

int line = 5; 
int column = 5;
int[,] array = new int[line, column];

ArrayRandomEvenPrint(array);

CoordinateLookPrint(array);
Console.WriteLine();

CoordinatePrint(array);


void CoordinateLookPrint(int[,] array)
{
int count = 0;
Console.WriteLine($"Веедённое число встречаеться в координатах: ");
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == numberUser)
            {
            Console.Write($"[{i},{j}] ");
            count++; 
            }
        } 

        }
            
    }
    Console.WriteLine(""); 
    
    if(count == 0)
    {
    Console.WriteLine($"0 раз");
    Console.Write($"Числа {numberUser} нет в массиве");  
    Console.WriteLine("");  
    }
}

void ArrayRandomEvenPrint(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToInt32(new Random().Next(2, 20));
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

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void CoordinatePrint(int[,] array)
{
if(array.GetLength(0) > coordinateI && array.GetLength(1) > coordinateJ)
    {
    Console.WriteLine($"Элимент в координатах: [{coordinateI},{coordinateJ}] = {array[coordinateI,coordinateJ]}"); 
    }
else
    {
    Console.Write($"Координат [{coordinateI},{coordinateJ}] нет в массиве");
    Console.WriteLine(); 
    }
    
}

