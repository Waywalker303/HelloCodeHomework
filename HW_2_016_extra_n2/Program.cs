// Задача 16 Напишите программу которая принимает на вход два числа и проверяет являеться ли одно квадратом другого
int numberOne = Input("Введите первое число: ");
int numberTwo = Input("Введите первое число: ");
if (numberOne * numberOne == numberTwo)
{
    Console.WriteLine("Да! Число: " + numberTwo + " является квадратом числа: " + numberOne);
}
else
{
    Console.WriteLine("Нет! Число: " + numberTwo + " не является квадратом числа: " + numberOne);
}
int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());

}