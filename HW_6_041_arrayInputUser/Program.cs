/* Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.Write("Введите числа через запятую: ");
string userText = Console.ReadLine();
//string userText = "0, 7, 8, -2, -2,-1, 1,-7, 567, 89, 223";
userText = userText + ",";
int[] array = new int[userText.Length];
string text = String.Empty;
int j = 0;

for(int i = 0; i < userText.Length; i++)
{
    if(userText[i] != ',')
    {
        text = text + userText[i];
    }
    else
    {
        array[j] = Convert.ToInt32(text);
        text = String.Empty;
        j++;
    }
    
}
ArrayEven(array);

void ArrayEven(int[] array)
{
int even = 0;
for(int i = 0; i < array.Length; i++)
{
     if(array[i] > even )
        {
        even++;
        }
}
Console.WriteLine($"Количество чисел больше нуля: {even}");
}