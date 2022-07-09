//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9; m = 3, n = 2 -> A(m,n) = 29

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");
int FunctionAkkermanPrint = FunctionAkkerman(m, n);



Console.Write($"Функция Аккермана = {FunctionAkkermanPrint}");
Console.WriteLine();



int FunctionAkkerman(int m, int n)
{
    if(m == 0)
    return
    n + 1;
    else if (n == 0)
    return 
    FunctionAkkerman(m - 1, 1 );
    else 
    return
    FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
