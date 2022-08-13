//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите  номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number > 5 && number < 8)
    {
        Console.WriteLine($"Да, {number} это выходной");
    }
    else
    {
        Console.WriteLine($"Нет, {number} это не выходной");
    }
}
else
{
    Console.WriteLine("НЕВЕРНОЕ ЧИСЛО! Введите число от 1 до 7");
}    