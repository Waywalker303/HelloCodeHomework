/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)  4, 4 -> 256
2, 4 -> 16 */

int number1 = Input("Введите первое число: ");
int number2 = Input("Введите второе число: ");
int result = 1;

for (int i = 1; i <= number2; i++)
{
    result = number1 * result; 
//    Console.Write(result);
}

Console.WriteLine($"{"Число"} {number1} {"степени"} {number2}{" ="} {result}");


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}