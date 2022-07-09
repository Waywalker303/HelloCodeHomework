//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120; M = 4; N = 8. -> 30

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");

int max = m;
{
if (n > max)
    max = n;
}

RecursionSum(m,n, max = 0);
Console.WriteLine();


void RecursionSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма = {sum}");
        return;
    }
    RecursionSum(m, n - 1, sum);
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}