/*13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int num;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

int num3(int num)
{
    while (num > 999)
    {
    num /=10;
    }
    return num % 10;
}

if (num < 100)
{
    Console.WriteLine("Nретьей цыфры нет");
}
else
{
    Console.WriteLine(num3(num));
}