//Все задачи должны быть решены с помощью рекурсии!!!
//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = Input("Введите число: ");
int count = 2;

Console.Write('"');
RecursionEvenPrint (n, count);
Console.Write(1);
Console.Write('"');
Console.WriteLine();

void RecursionEvenPrint (int n, int count)
{
    if (count > n)
    return;
    RecursionEvenPrint (n, count + 1);
    Console.Write(count + ", ");
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}