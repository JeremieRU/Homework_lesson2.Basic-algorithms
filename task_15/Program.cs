/*15 Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int number;
Console.Write($"Введите число, соответствующее дню недели: ");
int.TryParse(Console. ReadLine()!, out number);

if (number > 7 || number < 1)
{
Console.Write($"Вы ввели неверное число");
}
else if (number >= 1 && number <=5 )
{
Console.Write("Будный день");
}
else if (number >= 6 && number <= 7)
{
Console.Write("Выходной");
}